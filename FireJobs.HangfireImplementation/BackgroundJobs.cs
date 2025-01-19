namespace FireJobs.HangfireImplementation;

public static class BackgroundJobs
{
    public static void ExampleJob(string message)
    {
        Console.WriteLine($"Job Executed: {message} at {DateTime.Now}");
    }
}