using Test.Dotnet.Queue.Publisher.Core.Interfaces;
using Test.Dotnet.Queue.Publisher.Core.Services;

namespace Test.Dotnet.Queue.Publisher.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}
