using Microsoft.Extensions.DependencyInjection;
using VoiceCommerceShop.AppCore.MappingProfiles;

namespace VoiceCommerceShop.AppCore.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddAppCore(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddAutoMapper(typeof(CarProfile).Assembly);
    }
}