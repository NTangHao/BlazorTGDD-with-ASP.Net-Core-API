var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.TGDD_Api>("tgddapi");

builder.AddProject<Projects.TGDD_Web>("tgdd.web").WithReference(api);

builder.Build().Run();
