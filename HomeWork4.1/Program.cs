using HomeWork4._1;
using HomeWork4._1.Config;
using HomeWork4._1.Services;
using HomeWork4._1.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

void ConfigureServices(ServiceCollection serviceCollection, IConfiguration configuration)
{
    serviceCollection.AddOptions<ApiOption>().Bind(configuration.GetSection("Api"));
    serviceCollection
        .AddHttpClient()
        .AddTransient<IInternalHttpClientService, InternalHttpClientService>()
        .AddTransient<IUsersService, UsersService>()
        .AddTransient<ILoginService, LoginService>()
        .AddTransient<IRegistrationService, RegistrationService>()
        .AddTransient<App>();
}

IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .Build();

var serviceCollection = new ServiceCollection();
ConfigureServices(serviceCollection, configuration);
var provider = serviceCollection.BuildServiceProvider();

var app = provider.GetService<App>();
await app!.Start();