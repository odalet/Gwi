using NLog;

namespace Gwi.OpenGL.BindingGenerator
{
    internal abstract class BaseProcessor
    {
        private readonly ILogger log;
        private const string tab = "\t";
        private int indentationLevel;

        protected BaseProcessor(ILogger logger)
        {
            log = logger;
            LogIndentation = "";
        }

        protected string LogIndentation { get; private set; }

        protected void LogWarn(string text) => log.Warn($"{LogIndentation}{text}");
        protected void LogInfo(string text) => log.Info($"{LogIndentation}{text}");
        protected void LogDebug(string text) => log.Debug($"{LogIndentation}{text}");

        protected void IndentLog()
        {
            indentationLevel++;
            ApplyIndent();
        }

        protected void DedentLog()
        {
            indentationLevel--;
            ApplyIndent();
        }

        private void ApplyIndent()
        {
            if (indentationLevel < 0) indentationLevel = 0;
            if (indentationLevel == 0) LogIndentation = "";
            for (var i = 0; i < indentationLevel; i++)
                LogIndentation += tab;
        }
    }
}
