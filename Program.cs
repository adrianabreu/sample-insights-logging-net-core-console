using System;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace console_app_logging_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddLogging(loggingBuilder => 
            loggingBuilder
            .AddConsole()
            .AddFilter<Microsoft.Extensions.Logging.ApplicationInsights.ApplicationInsightsLoggerProvider>("", LogLevel.Information));

            collection.AddApplicationInsightsTelemetryWorkerService("ikey");
            var provider = collection.BuildServiceProvider();
            
            var telemetryClient = provider.GetRequiredService<TelemetryClient>();
            var logger = provider.GetRequiredService<ILogger<Program>>();


            logger.LogInformation("Testing");

            telemetryClient.Flush();
            Task.Delay(5000).Wait();
        }
    }
}
