using Microsoft.Extensions.Logging;

namespace DVPostDataClient.RunTime.Logger
{
    internal static class LocalLoggerExtensions
    {
        public static ILoggerFactory AddFile(this ILoggerFactory factory, string filePath)
        {
            factory.AddProvider(new LocalLoggerProvider(filePath));
            return factory;
        }
    }
}
