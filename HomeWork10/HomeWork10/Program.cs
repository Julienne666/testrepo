using HomeWork10;
using HomeWork10.Config;
using HomeWork10.Repositories;
using HomeWork10.Services;
using HomeWork10.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Sockets;
void ConfigureServices(ServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddOptions<LoggerOption>().Bind(configuration.GetSection("Logger"));

        serviceCollection.AddTransient<IAppliancePowerService, AppliancePowerService>()
            .AddTransient<ISortAndFindApplianceService, SortAndFindApplianceService>()
            .AddTransient<IElectricalApplianceRepository, ElectricalApplianceRepository>()
            .AddSingleton<ILoggerService, LoggerService>()
            .AddTransient<App>();
    }

    IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .Build();

    var serviceCollection = new ServiceCollection();
    ConfigureServices(serviceCollection, configuration);
    var provider = serviceCollection.BuildServiceProvider();

    var app = provider.GetService<App>();
    app!.Run();
