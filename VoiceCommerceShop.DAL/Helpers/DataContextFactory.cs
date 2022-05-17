using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace VoiceCommerceShop.DAL.Helpers;

public class MyContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<DataContext>();
        builder.UseSqlServer("Data Source=localhost;Initial Catalog=VoiceCommerceShop;Integrated Security=True");

        return new DataContext(builder.Options);
    }
}