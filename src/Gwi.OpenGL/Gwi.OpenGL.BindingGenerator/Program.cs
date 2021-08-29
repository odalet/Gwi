using System;
using System.Diagnostics;
using System.IO;
using Gwi.OpenGL.BindingGenerator.Parsing;
using NLog;

namespace Gwi.OpenGL.BindingGenerator
{
    // Adapted from OpenTK's generator (https://github.com/opentk/opentk/tree/opentk5.0)
    internal sealed class Program
    {
        private static readonly ILogger log = LogManager.GetCurrentClassLogger();

        private static int Main(string[] args)
        {
            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                new Program().Run();
                stopwatch.Stop();
                log.Info($"Generation took {stopwatch.Elapsed}");

                return 0;
            }
            catch (Exception ex)
            {
                log.Error(ex, $"Generation failed: {ex.Message}");
                return -1;
            }
        }

        private void Run()
        {
            var glXmlSourceFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input", "gl.xml");

            var parser = new Parser(glXmlSourceFile);
            var tree = parser.Parse();
            DumpParseTree(tree); // for debugging purpose

            var transformer = new Transformer(tree);
            var specification = transformer.Transform();

            var foo = 42;

            ////////// Let's extract the expressions
            //////////var exprs = specification.Commands.SelectMany(c => c.Parameters).Select(p => p.Length).Where(x => x != null && x is CompSize c && c.Parameters.Length > 3).ToArray();

            ////////// glClearTexImage
            ////////var exprs = specification.Commands.Where(c => c.EntryPoint == "glClearTexImage").SelectMany(c => c.Parameters).Select(p => p.Length)
            ////////    //.Where(x => x != null && x is CompSize c && c.Parameters.Length > 3)
            ////////    .ToArray();

            //////////// Reading the gl.xml file.
            //////////using var stream = Reader.ReadSpecFromGithub();

            //////////// TODO: Documentation.

            //////////// Parsing into data structures.
            //////////var specification = Parser.Parse(stream);

            //////////// Processer/overloading
            //////////var outputSpec = Processor.ProcessSpec(specification);

            //////////// Writing cs files.
            //////////Writer.Write(outputSpec);
        }

        private static void DumpParseTree(ParseTree tree)
        {
            using var file = File.CreateText(@"c:\temp\gl.md");
            ParseTreeDumper.DumpToMarkdown(file, tree);
        }
    }
}
