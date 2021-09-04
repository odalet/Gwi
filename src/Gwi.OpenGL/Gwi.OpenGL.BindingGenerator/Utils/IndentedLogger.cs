using System;
using System.Collections.Generic;
using NLog;

namespace Gwi.OpenGL.BindingGenerator.Utils
{
    internal enum IndentedLoggerStyle
    {
        Default,
        Braces
    }

    internal sealed class IndentedLogger
    {
        private sealed class Scope : IDisposable
        {
            public Scope(IndentedLogger owner, LogLevel? level, string? message)
            {
                Logger = owner;
                LogLevel = level;
                Message = message;

                Begin();
            }

            private IndentedLogger Logger { get; }
            private LogLevel? LogLevel { get; }
            private string? Message { get; }

            public void Dispose() => End();

            private void Begin()
            {
                if (Message != null)
                {
                    var level = LogLevel ?? LogLevel.Info;
                    Logger.Log(level, GetBeginMessage(Logger.Style, Message));
                }

                Logger.Push();
            }

            private void End()
            {
                Logger.Pop();

                if (Message != null)
                {
                    var level = LogLevel ?? LogLevel.Info;
                    Logger.Log(level, GetEndMessage(Logger.Style, Message)); 
                }
            }

            private static string GetBeginMessage(IndentedLoggerStyle style, string message) => style switch
            {
                IndentedLoggerStyle.Default => $"> {message}",
                IndentedLoggerStyle.Braces => $"{message} {{",
                _ => ""
            };

            private static string GetEndMessage(IndentedLoggerStyle style, string message) => style switch
            {
                IndentedLoggerStyle.Default => $"< {message}",
                IndentedLoggerStyle.Braces => "}",
                _ => ""
            };
        }

        private readonly Stack<int> indentationLevels = new();

        public IndentedLogger(ILogger logger, IndentedLoggerStyle style = IndentedLoggerStyle.Default)
        {
            Logger = logger;
            Style = style;
            indentationLevels.Push(0);
        }

        private ILogger Logger { get; }
        private IndentedLoggerStyle Style { get; }
        private int IndentationLevel => indentationLevels.Peek();
        private string Indentation => new(' ', IndentationLevel * 2);

        public void Log(LogLevel level, string message) => Logger.Log(level, TweakMessage(message));
        public void Log(LogLevel level, string message, Exception exception) => Logger.Log(level, exception, TweakMessage(message));

        public IDisposable NewScope(LogLevel? level, string? message = null) => new Scope(this, level, message);

        private string TweakMessage(string message) => $"{Indentation}{message}";

        private void Push() => indentationLevels.Push(IndentationLevel + 1);
        private void Pop() => indentationLevels.Pop();
    }

    internal static class ScopedLoggerExtensions
    {
        public static IDisposable NewScope(this IndentedLogger logger) => logger.NewScope(null, null);
        public static IDisposable NewScope(this IndentedLogger logger, string message) => logger.NewScope(LogLevel.Info, message);

        public static void Fatal(this IndentedLogger logger, string message) => logger.Log(LogLevel.Fatal, message);
        public static void Fatal(this IndentedLogger logger, string message, Exception exception) => logger.Log(LogLevel.Fatal, message, exception);

        public static void Error(this IndentedLogger logger, string message) => logger.Log(LogLevel.Error, message);
        public static void Error(this IndentedLogger logger, string message, Exception exception) => logger.Log(LogLevel.Error, message, exception);

        public static void Warn(this IndentedLogger logger, string message) => logger.Log(LogLevel.Warn, message);
        public static void Warn(this IndentedLogger logger, string message, Exception exception) => logger.Log(LogLevel.Warn, message, exception);

        public static void Info(this IndentedLogger logger, string message) => logger.Log(LogLevel.Info, message);
        public static void Info(this IndentedLogger logger, string message, Exception exception) => logger.Log(LogLevel.Info, message, exception);

        public static void Debug(this IndentedLogger logger, string message) => logger.Log(LogLevel.Debug, message);
        public static void Debug(this IndentedLogger logger, string message, Exception exception) => logger.Log(LogLevel.Debug, message, exception);

        public static void Trace(this IndentedLogger logger, string message) => logger.Log(LogLevel.Trace, message);
        public static void Trace(this IndentedLogger logger, string message, Exception exception) => logger.Log(LogLevel.Trace, message, exception);
    }
}
