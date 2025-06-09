using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<CargoTracking_Server_WebAPI>("cargo-tracking-webapi");

builder.Build().Run();
