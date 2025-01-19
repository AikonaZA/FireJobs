using FireJobs.HangfireImplementation;
using Hangfire;
using Hangfire.MemoryStorage;

// Configure Hangfire with in-memory storage
GlobalConfiguration.Configuration
    .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
    .UseColouredConsoleLogProvider()
    .UseSimpleAssemblyNameTypeSerializer()
    .UseRecommendedSerializerSettings()
    .UseMemoryStorage();

// Enqueue an immediate job
BackgroundJob.Enqueue(() => Console.WriteLine("Hello, world!"));

// Configure and start the Hangfire server
using var server = new BackgroundJobServer();
Console.WriteLine("Hangfire Server started. Press Enter to exit...");

// Schedule a recurring job to run every minute
RecurringJob.AddOrUpdate(
    "example-job", // Unique ID for the job
    () => BackgroundJobs.ExampleJob("Recurring job"),
    Cron.Minutely // Cron expression for every minute
);

// Keep the console app running
Console.ReadLine();