using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<FireJobs_ApiService>("API-Service");

builder.AddProject<FireJobs_Web>("WebFrontEnd")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.AddProject<FireJobs_ConsoleApp>("FireJobs-ConsoleApp");

await builder.Build().RunAsync();