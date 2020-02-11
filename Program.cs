using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace console_app_logging_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddLogging(builder => {
                builder
                .AddConsole()
                .AddApplicationInsights("key")
                .SetMinimumLevel(LogLevel.Information);
            });
            var provider = collection.BuildServiceProvider();

            var logger = provider.GetService<ILogger<Program>>();
            logger.LogInformation("Testing");
        }
    }
}
