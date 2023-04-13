using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MovieRatingAppBackend.Persistence.Contexts;

public class ApplicationDesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    private readonly IConfiguration _configuration;

    public ApplicationDesignTimeDbContextFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var connectionString = _configuration.GetConnectionString("SqlServer");

        DbContextOptionsBuilder<ApplicationDbContext> builder = new();
        builder.UseSqlServer(connectionString);

        return new ApplicationDbContext(builder.Options);
    }
}