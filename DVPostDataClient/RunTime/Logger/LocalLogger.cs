using System;
using System.IO;

using Microsoft.Extensions.Logging;

namespace DVPostDataClient.RunTime.Logger
{
    internal class LocalLogger : ILogger
    {
        private readonly string filePath;
        private static object _lock = new object();
        public LocalLogger(string path)
        {
            filePath = path;
        }

        public bool IsEnabled(LogLevel logLevel) => true;

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (formatter == null)
                return;

            lock (_lock)
            {
                File.AppendAllText(filePath, formatter(state, exception) + Environment.NewLine);
            }
        }
    }
}
