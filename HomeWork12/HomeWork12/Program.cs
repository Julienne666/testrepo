using HomeWork12;
using HomeWork12.Repositories;
using HomeWork12.Repositories.Abstractions;
using HomeWork12.Services;
using HomeWork12.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;
void ConfigureServices(ServiceCollection serviceCollection)
{
    serviceCollection.AddTransient<IContactsRepository, ContactsRepository>()
        .AddTransient<IPhoneBookService, PhoneBookService>()
        .AddTransient<App>();
}

var serviceCollection = new ServiceCollection();
ConfigureServices(serviceCollection);
var provider = serviceCollection.BuildServiceProvider();

var app = provider.GetService<App>();
app!.Run();
