using System;
using System.Diagnostics;
using System.IO;
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
            //parser.DumpStatistics();
            //return;

            var tree = parser.Parse();

            var here = AppDomain.CurrentDomain.BaseDirectory;
            var target = Path.Combine(here, "../../../..", "Gwi.OpenGL", "generated");
            var generator = new CodeGenerator(target, debug: true);
            generator.Write(tree);


            //DumpParseTree(tree); // for debugging purpose

            //var transformer = new Transformer(tree);
            //var specification = transformer.Transform();

            //var here = AppDomain.CurrentDomain.BaseDirectory;
            //var target = Path.Combine(here, "../../../..", "Gwi.OpenGL", "generated");
            //var writer = new CodeWriter(target, debug: true);
            //writer.Write(specification);
        }

        //private static void DumpParseTree(ParseTree tree)
        //{
        //    using var file = File.CreateText(@"c:\temp\gl.md");
        //    ParseTreeDumper.DumpToMarkdown(file, tree);
        //}
    }
}
