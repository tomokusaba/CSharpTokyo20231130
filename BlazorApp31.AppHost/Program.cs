var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorApp31>("blazorapp31");

builder.Build().Run();
