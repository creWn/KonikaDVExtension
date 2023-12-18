using Microsoft.Extensions.Logging;

namespace DVPostDataClient.RunTime.Logger
{
    internal class LocalLoggerProvider : ILoggerProvider
    {
        private readonly string path;
        public LocalLoggerProvider(string _path)
        {
            path = _path;
        }

        public ILogger CreateLogger(string categoryName) => new LocalLogger(path);

        public void Dispose() {}
    }
}
