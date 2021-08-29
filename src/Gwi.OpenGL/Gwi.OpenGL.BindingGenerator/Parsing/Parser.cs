using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Gwi.OpenGL.BindingGenerator.Utils;
using NLog;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    internal sealed class Parser : BaseProcessor
    {
        public Parser(string filename) : base(LogManager.GetCurrentClassLogger()) => FileName = filename;

        private string FileName { get; }

        public ParseTree Parse()
        {
            if (!File.Exists(FileName)) throw new FileNotFoundException("Missing input OpenGL Api definition", FileName);

            var xdoc = XDocument.Load(FileName);
            return xdoc.Root == null ?
                throw new ParsingException("The input XML data doesn't contain a Root node.") :
                Parse(xdoc.Root);
        }

        private ParseTree Parse(XElement root)
        {
            using (NewLogScope("Parse gl.xml"))
            {
                var commands = LogScoped(() => ParseCommands(root), "Parse Commands");
                var enumerations = LogScoped(() => ParseEnumerants(root), "Parse Enumerations");
                var features = LogScoped(() => ParseFeatures(root), "Parse Features");
                var extensions = LogScoped(() => ParseExtensions(root), "Parse Extensions");

                return new ParseTree(commands, enumerations, features, extensions);
            }
        }

        private IReadOnlyCollection<Command> ParseCommands(XElement xe)
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

            Log.Info($"{commands.Count} commands were parsed");
            return commands;
        }

        private static Command ParseCommand(XElement xe, string commandNamespace)
        {
            var xeProto = xe.Element("proto");
            if (xeProto == null) throw new ParsingException("Missing proto in command");
            var returnType = ParsePType(xeProto);

            var entryPoint = xeProto.Element("name")?.Value;
            if (string.IsNullOrEmpty(entryPoint)) throw new ParsingException("Missing name command/proto");

            var parameters = new List<GLParameter>();
            foreach (var element in xe.Elements("param"))
            {
                var paramName = element.Element("name")?.Value;
                if (string.IsNullOrEmpty(paramName)) throw new ParsingException("Missing parameter name in command/param");

                var ptype = ParsePType(element);

                var len = element.Attribute("len")?.Value ?? "";
                var paramLength = string.IsNullOrEmpty(len) ? null : ExprParser.Parse(len);

                parameters.Add(new GLParameter(ptype, paramName, paramLength));
            }

            return new(commandNamespace, entryPoint, returnType, parameters.ToArray());
        }

        private static PType ParsePType(XElement xe)
        {
            var group = xe.Attribute("group")?.Value;
            var className = xe.Attribute("class")?.Value;
            var handle = className switch
            {
                null => (HandleType?)null,
                "program" => HandleType.ProgramHandle,
                "program pipeline" => HandleType.ProgramPipelineHandle,
                "texture" => HandleType.TextureHandle,
                "buffer" => HandleType.BufferHandle,
                "shader" => HandleType.ShaderHandle,
                "query" => HandleType.QueryHandle,
                "framebuffer" => HandleType.FramebufferHandle,
                "renderbuffer" => HandleType.RenderbufferHandle,
                "sampler" => HandleType.SamplerHandle,
                "transform feedback" => HandleType.TransformFeedbackHandle,
                "vertex array" => HandleType.VertexArrayHandle,
                // The "Sync" class is already marked with the "GLSync" type which is handled differently from the other types
                // We leave it null here to let the "GLSync" handling do this.
                "sync" => null,
                "display list" => HandleType.DisplayListHandle,
                _ => throw new ParsingException(className + " is not a supported handle type yet!"),
            };

            var parameterType = GetXmlText(xe, e => e.Name == "name" ? string.Empty : e.Value).Trim();
            return new PType(GLTypeParser.Parse(parameterType), handle, group);
        }

        private IReadOnlyCollection<Enumerant> ParseEnumerants(XElement xe)
        {
            static EnumerantType parseEnumerantType(string value) => value switch
            {
                "" => EnumerantType.None,
                "bitmask" => EnumerantType.Bitmask,
                _ => EnumerantType.Invalid,
            };

            var enums = new List<Enumerant>();
            foreach (var xeEnums in xe.Elements("enums"))
            {
                var ns = xeEnums.Attribute("namespace")?.Value;
                if (string.IsNullOrEmpty(ns)) throw new ParsingException($"Enum '{xeEnums}' is missing a namespace attribute.");

                var groups = xeEnums.Attribute("group")?.Value?.Split(',', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
                var vendor = xeEnums.Attribute("vendor")?.Value ?? "";
                var enumType = parseEnumerantType(xeEnums.Attribute("type")?.Value ?? "");

                // An Enums either has both start/end or none
                var startString = xeEnums.Attribute("start")?.Value;
                var endString = xeEnums.Attribute("end")?.Value;
                if (startString == null && endString != null || startString != null && endString == null)
                    throw new ParsingException($"Enums '{xeEnums}' is missing either a start or an end attribute.");

                Range? range = null;
                if (startString != null && endString != null)
                {
                    var start = ParseInt(startString);
                    var end = ParseInt(endString);
                    range = new Range(start, end);
                }

                var comment = xeEnums.Attribute("comment")?.Value ?? "";

                // Should we parse 'unused' entries?
                var entries = new List<EnumerantEntry>();
                foreach (var xeEnum in xeEnums.Elements("enum"))
                    entries.Add(ParseEnumerantEntry(xeEnum));

                enums.Add(new Enumerant(ns, groups, enumType, vendor, range, comment, entries));
            }

            Log.Info($"{enums.Count} enums were parsed");
            return enums;
        }

        private static EnumerantEntry ParseEnumerantEntry(XElement xe)
        {
            static TypeSuffix parseSuffix(string suffix) => suffix switch
            {
                "" => TypeSuffix.None,
                "u" => TypeSuffix.U,
                "ull" => TypeSuffix.Ull,
                _ => TypeSuffix.Invalid,
            };

            static ulong convertToUInt64(string value, TypeSuffix type) => type switch
            {
                TypeSuffix.None => (uint)(int)new Int32Converter().ConvertFromString(value),
                TypeSuffix.Ull => (ulong)(long)new Int64Converter().ConvertFromString(value),
                TypeSuffix.U => (uint)new UInt32Converter().ConvertFromString(value),
                TypeSuffix.Invalid or _ => throw new ParsingException($"Invalid type suffix '{type}'!"),
            };

            var name = xe.Attribute("name")?.Value;
            if (string.IsNullOrEmpty(name)) throw new ParsingException($"Enum entry has no name");

            var valueString = xe.Attribute("value")?.Value;
            if (string.IsNullOrEmpty(valueString)) throw new ParsingException($"Enum entry '{name}' has no value");

            var suffix = parseSuffix(xe.Attribute("type")?.Value ?? "");
            var value = convertToUInt64(valueString, suffix);
            var alias = xe.Attribute("alias")?.Value ?? "";
            var groups = xe.Attribute("group")?.Value?.Split(',', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
            var comment = xe.Attribute("comment")?.Value ?? "";
            var api = ParseGLApi(xe.Attribute("api")?.Value ?? "");

            return new EnumerantEntry(name, api, value, alias, comment, groups, suffix);
        }

        private IReadOnlyCollection<Feature> ParseFeatures(XElement xe)
        {
            var features = new List<Feature>();
            foreach (var xeFeature in xe.Elements("feature"))
            {
                var name = xeFeature.Attribute("name")?.Value;
                if (string.IsNullOrEmpty(name)) throw new ParsingException($"Feature has no name.");

                var apiString = xeFeature.Attribute("api")?.Value;
                if (string.IsNullOrEmpty(apiString)) throw new ParsingException($"Feature '{name}' is missing an api attribute.");

                var number = xeFeature.Attribute("number")?.Value;
                if (string.IsNullOrEmpty(number)) throw new ParsingException($"Feature '{name}' is missing a version number attribute.");

                var version = Version.Parse(number);
                var api = ParseGLApi(apiString);

                var requireEntries = new List<RequireEntry>();
                foreach (var xeRequire in xeFeature.Elements("require"))
                    requireEntries.Add(ParseRequire(xeRequire));

                var removeEntries = new List<RemoveEntry>();
                foreach (var xeRemove in xeFeature.Elements("remove"))
                    removeEntries.Add(ParseRemove(xeRemove));

                features.Add(new Feature(api, version, name, requireEntries, removeEntries));
            }

            Log.Info($"{features.Count} features were parsed");
            return features;
        }

        private IReadOnlyCollection<Extension> ParseExtensions(XElement xe)
        {
            var extensions = new List<Extension>();
            foreach (var xeExtension in xe.Element("extensions")!.Elements("extension"))
            {
                var name = xeExtension.Attribute("name")?.Value;
                if (string.IsNullOrEmpty(name)) throw new ParsingException($"Extension has no name.");

                // Remove "GL_" and get the vendor name from the first part of the extension name
                // Extension name convention: "GL_VENDOR_EXTENSION_NAME"
                var nameWithoutPrefix = NameMangler.RemoveStart(name, "GL_");
                var vendor = nameWithoutPrefix[..nameWithoutPrefix.IndexOf("_")];
                if (string.IsNullOrEmpty(vendor)) throw new ParsingException($"Extension '{name}' doesn't define a vendor in its name!");

                // 3DFX is a vendor...
                if (char.IsDigit(vendor[0])) vendor = "_" + vendor;

                var comment = xeExtension.Attribute("comment")?.Value ?? "";

                var supportedApis = xeExtension
                    .Attribute("supported")?.Value?
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .Select(ParseGLApi).ToArray();

                if (supportedApis == null || supportedApis.Length == 0)
                    throw new ParsingException($"Extension '{name}' did not specify any supported APIs.");

                var requires = new List<RequireEntry>();
                foreach (var xeRequire in xeExtension.Elements("require"))
                    requires.Add(ParseRequire(xeRequire));

                extensions.Add(new Extension(name, vendor, supportedApis, comment, requires));
            }

            Log.Info($"{extensions.Count} extensions were parsed");
            return extensions;
        }

        private static RequireEntry ParseRequire(XElement xe)
        {
            var api = ParseGLApi(xe.Attribute("api")?.Value ?? "");
            var profile = ParseGLProfile(xe.Attribute("profile")?.Value ?? "");
            var comment = xe.Attribute("comment")?.Value ?? "";

            var commands = new List<string>();
            var enums = new List<string>();

            foreach (var xeEntry in xe.Elements())
            {
                // A few entries here have a comment attribute, but we don't bother with it yet
                var name = xeEntry.Attribute("name")?.Value;
                if (string.IsNullOrEmpty(name)) throw new ParsingException($"The Require entry '{xeEntry}' does not have a name attribute.");

                switch (xeEntry.Name.LocalName)
                {
                    case "command": commands.Add(name); break;
                    case "enum": enums.Add(name); break;
                    default: continue;
                }
            }

            return new RequireEntry(api, profile, comment, commands, enums);
        }

        private static RemoveEntry ParseRemove(XElement xe)
        {
            var profile = ParseGLProfile(xe.Attribute("profile")?.Value ?? "");
            var comment = xe.Attribute("comment")?.Value ?? "";

            var removeCommands = new List<string>();
            var removeEnums = new List<string>();

            foreach (var xeEntry in xe.Elements())
            {
                // A few entries here have a comment attribute, but we don't bother with it yet
                var name = xeEntry.Attribute("name")?.Value;
                if (string.IsNullOrEmpty(name)) throw new ParsingException($"The Remove entry '{xeEntry}' does not have a name attribute.");

                switch (xeEntry.Name.LocalName)
                {
                    case "command": removeCommands.Add(name); break;
                    case "enum": removeEnums.Add(name); break;
                    default: continue;
                }
            }

            return new RemoveEntry(profile, comment, removeCommands, removeEnums);
        }

        private static GLApi ParseGLApi(string api) => api switch
        {
            "" or "disabled" => GLApi.None,
            "gl" => GLApi.GL,
            "gles1" => GLApi.GLES1,
            "gles2" => GLApi.GLES2,
            "glsc2" => GLApi.GLSC2,
            "glcore" => GLApi.GLCore,
            _ => GLApi.Invalid,
        };

        public static GLProfile ParseGLProfile(string profile) => profile switch
        {
            "" => GLProfile.None,
            "core" => GLProfile.Core,
            "compatibility" => GLProfile.Compatibility,
            "common" => GLProfile.Common,
            _ => GLProfile.Invalid,
        };

        private static int ParseInt(string str)
        {
            var isHex = str.StartsWith("0x");
            if (isHex) str = str[2..];
            return int.Parse(str, isHex ? NumberStyles.HexNumber : NumberStyles.Integer);
        }

        private static string GetXmlText(XElement element, Func<XElement, string> elementTransformer)
        {
            var sb = new StringBuilder();

            foreach (var node in element.Nodes()) _ = node switch
            {
                XText xtext => sb.Append(xtext.Value),
                XElement xelement => sb.Append(elementTransformer(xelement)),
                _ => sb.Append(node),
            };

            return sb.ToString();
        }
    }
}
