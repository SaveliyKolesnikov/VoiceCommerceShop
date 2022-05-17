using Microsoft.EntityFrameworkCore;
using VoiceCommerceShop.DAL.EntityConfigurations;
using VoiceCommerceShop.DAL.Helpers;
using VoiceCommerceShop.Domain;

namespace VoiceCommerceShop.DAL;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> configuration) : base(configuration)
    {
    }

    public DbSet<Car> Cars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CarEntityTypeConfiguration());
        modelBuilder.Entity<Car>().HasData(DataSeed.GetCars());
    }
}