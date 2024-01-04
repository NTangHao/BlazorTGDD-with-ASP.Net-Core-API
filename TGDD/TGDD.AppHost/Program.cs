var builder = DistributedApplication.CreateBuilder(args);
var cache = builder.AddRedis("cache");

var api = builder.AddProject<Projects.TGDD_Api>("tgddapi").WithReference(cache);



builder.AddProject<Projects.TGDD_Web>("tgddweb")
    .WithReference(cache)
    .WithReference(api);


builder.AddProject<Projects.TGDDMessaging>("tgddmessaging");

builder.AddProject<Projects.TGDDMessaging_Worker>("tgddmessagingworker");


builder.Build().Run();
