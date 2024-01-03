using Azure.Messaging.ServiceBus;

namespace TGDDMessaging.Worker;

public class Worker(
    ILogger<Worker> logger,
    ServiceBusClient client) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {


        var processor = client.CreateProcessor(
            "mytopic",
            "S1",
            new ServiceBusProcessorOptions());

        try
        {

            // add handler to process messages
            processor.ProcessMessageAsync += MessageHandler;

            // add handler to process any errors
            processor.ProcessErrorAsync += ErrorHandler;

            // start processing
            await processor.StartProcessingAsync();

            logger.LogInformation(
                "Wait for a minute and then press any key to end the processing");
            Console.ReadKey();

            // stop processing
            logger.LogInformation("\nStopping the receiver...");
            await processor.StopProcessingAsync();
            logger.LogInformation("Stopped receiving messages");
        }
        finally
        {
            // Calling DisposeAsync on client types is required to ensure that network
            // resources and other unmanaged objects are properly cleaned up.
            await processor.DisposeAsync();
            await client.DisposeAsync();
        }
    }

    async Task MessageHandler(ProcessMessageEventArgs args)
    {
        string body = args.Message.Body.ToString();
        logger.LogInformation("Received: {Body} from subscription.", body);

        // complete the message. messages is deleted from the subscription.
        await args.CompleteMessageAsync(args.Message);
    }

    // handle any errors when receiving messages
    Task ErrorHandler(ProcessErrorEventArgs args)
    {
        logger.LogError(args.Exception, args.Exception.Message);
        return Task.CompletedTask;
    }
}
