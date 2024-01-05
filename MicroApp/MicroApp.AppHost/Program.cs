var builder = DistributedApplication.CreateBuilder(args);

var redis = builder.AddRedisContainer("cache");

var productapi = builder.AddProject<Projects.Products_API>("productsapi");

builder.AddProject<Projects.CloneTGDD_Web>("clonetgddweb")
    .WithReference(productapi)
    .WithReference(redis);

builder.Build().Run();
