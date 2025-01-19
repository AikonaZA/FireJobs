using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.Extensions.DependencyInjection;

namespace FireJobs.HangfireImplementation;

public static class HangfireExtensions
{
    public static void AddHangfireServices(this IServiceCollection services)
    {
        // Configure Hangfire to use in-memory storage
        services.AddHangfire(config => config.UseMemoryStorage());

        // Add Hangfire server
        services.AddHangfireServer();
    }
}