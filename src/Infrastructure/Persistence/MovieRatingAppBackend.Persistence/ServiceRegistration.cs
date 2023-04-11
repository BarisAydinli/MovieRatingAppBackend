using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieRatingAppBackend.Persistence.Contexts;

namespace MovieRatingAppBackend.Persistence;

public static class ServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(opt =>
        {
            opt.UseNpgsql(configuration.GetConnectionString("PostgreSql"));
        });
        
        return services;
    }
}