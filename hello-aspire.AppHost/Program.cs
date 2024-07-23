var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.hello_aspire_ApiService>("apiservice");

builder.AddProject<Projects.hello_aspire_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
