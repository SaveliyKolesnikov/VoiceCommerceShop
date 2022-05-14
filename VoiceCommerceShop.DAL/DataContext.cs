using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VoiceCommerceShop.DAL.EntityConfigurations;
using VoiceCommerceShop.DAL.Helpers;
using VoiceCommerceShop.Domain;

namespace VoiceCommerceShop.DAL;

public class DataContext : DbContext
{
    private readonly IConfiguration configuration;

    public DataContext(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(configuration.GetConnectionString("WebApiDatabase"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CarEntityTypeConfiguration());
        modelBuilder.Entity<Car>().HasData(DataSeed.GetCars());
    }

    public DbSet<Car> Cars { get; set; }
}