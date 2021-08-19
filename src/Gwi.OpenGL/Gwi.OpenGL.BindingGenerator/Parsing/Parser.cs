using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using Gwi.OpenGL.BindingGenerator.Utils;
using NLog;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    internal sealed class Parser
    {
        private readonly IndentedLogger log = new(LogManager.GetCurrentClassLogger());

        public Parser(string filename) => FileName = filename;

        private string FileName { get; }

        public Specification Parse()
        {
            if (!File.Exists(FileName)) throw new FileNotFoundException("Missing input OpenGL Api definition", FileName);

            var xdoc = XDocument.Load(FileName);
            if (xdoc.Root == null) throw new ParsingException("The input XML data doesn't contain a Root node.");

            return Parse(xdoc.Root);
        }

        private Specification Parse(XElement root)
        {
            using (log.NewScope("Parse gl.xml"))
            {
                var commands = LogScoped(() => ParseCommands(root), "Parse Commands");
                var enumerations = LogScoped(() => ParseEnumerations(root), "Parse Enumerations");
                var features = LogScoped(() => ParseFeatures(root), "Parse Features");
                var extensions = LogScoped(() => ParseExtensions(root), "Parse Extensions");

                return new Specification(commands, enumerations, features, extensions);
            }
        }

        private IEnumerable<Command> ParseCommands(XElement xe)
        {
            var commands = new List<Command>();

            foreach (var xeCommands in xe.Elements("commands"))
            {
                var ns = xeCommands.Attribute("namespace")?.Value ?? "";
                foreach (var element in xeCommands.Elements("command"))
                {
                    var command = ParseCommand(element, ns);
                    commands.Add(command);
                }
            }

            log.Info($"{commands.Count} commands were parsed");
            return commands;
        }

        private Command ParseCommand(XElement xe, string commandNamespace)
        {
            var xeProto = xe.Element("proto");
            if (xeProto == null) throw new ParsingException("Missing proto in command");
            var returnType = ParsePType(xeProto);

            var entryPoint = xeProto.Element("name")?.Value ?? "";
            if (string.IsNullOrEmpty(entryPoint)) throw new ParsingException("Missing name command/proto");

            var parameters = new List<GLParameter>();
            foreach (var element in xe.Elements("param"))
            {
                var paramName = element.Element("name")?.Value ?? "";
                if (string.IsNullOrEmpty(paramName)) throw new ParsingException("Missing parameter name in command/param");

                var ptype = ParsePType(element);

                var len = element.Attribute("len")?.Value ?? "";
                var paramLength = string.IsNullOrEmpty(len) ? null : ParseExpr(len);

                parameters.Add(new GLParameter(ptype, paramName, paramLength));
            }

            return new(commandNamespace, entryPoint, returnType, parameters.ToArray());
        }

        private PType ParsePType(XElement xe) => new();

        private Expr ParseExpr(string expression) => new ExprParser(expression).Parse();

        private IEnumerable<Enumeration> ParseEnumerations(XElement xe)
        {
            return Array.Empty<Enumeration>();
        }

        private IEnumerable<Feature> ParseFeatures(XElement xe)
        {
            return Array.Empty<Feature>();
        }

        private IEnumerable<Extension> ParseExtensions(XElement xe)
        {
            return Array.Empty<Extension>();
        }



        private T LogScoped<T>(Func<T> todo, string message)
        {
            using (log.NewScope(message))
                return todo();
        }
    }
}
