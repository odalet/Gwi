using System;
using Gwi.OpenGL.BindingGenerator.Utils;
using NLog;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    internal class BaseProcessor
    {
        protected BaseProcessor(ILogger log) => Log = new IndentedLogger(log, IndentedLoggerStyle.Braces);

        protected IndentedLogger Log { get; }

        protected IDisposable NewLogScope(string message) => Log.NewScope(message);

        protected T LogScoped<T>(Func<T> todo, string message)
        {
            using (NewLogScope(message))
                return todo();
        }

        protected void LogScoped(Action todo, string message)
        {
            using (NewLogScope(message))
                todo();
        }
    }
}
