using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoiceCommerceShop.Domain;

namespace VoiceCommerceShop.DAL.EntityConfigurations;

public class CarEntityTypeConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(c => c.CarKey);
        builder.Property(c => c.CarKey).ValueGeneratedOnAdd();
    }
}