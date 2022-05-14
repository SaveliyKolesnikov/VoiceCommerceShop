using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace VoiceCommerceShop.DAL.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddDal(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        return serviceCollection.AddDbContext<DataContext>(o =>
            o.UseSqlServer(configuration.GetConnectionString("WebApiDatabase")));
    }
}