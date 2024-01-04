using TGDDMessaging.Worker;

var builder = Host.CreateApplicationBuilder(args);

builder.AddServiceDefaults();
builder.Services.AddHostedService<Worker>();
builder.AddAzureServiceBus("serviceBusConnection");


var host = builder.Build();
host.Run();
