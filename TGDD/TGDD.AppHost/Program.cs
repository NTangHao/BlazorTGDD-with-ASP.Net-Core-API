var builder = DistributedApplication.CreateBuilder(args);

//var redis = builder.AddRedisContainer("cache");

//var api = builder.AddProject<Projects.TGDD_Api>("tgddapi").WithReference(redis);

//builder.AddProject<Projects.TGDD_Web>("tgddweb").WithReference(api).WithReference(redis);

var api = builder.AddProject<Projects.TGDD_Api>("tgddapi");

builder.AddProject<Projects.TGDD_Web>("tgddweb").WithReference(api);

builder.AddProject<Projects.TGDDMessaging>("tgddmessaging");

builder.AddProject<Projects.TGDDMessaging_Worker>("tgddmessagingworker");


builder.Build().Run();
