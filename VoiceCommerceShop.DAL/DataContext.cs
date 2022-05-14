using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VoiceCommerceShop.Domain;

namespace VoiceCommerceShop.DAL;
public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {

    }

    public DbSet<Car> Cars { get; set; }
}