var builder = DistributedApplication.CreateBuilder(args);

builder.AddKafka("kafka")
    .WithKafkaUI()
    .WithDataVolume();

builder.Build().Run();