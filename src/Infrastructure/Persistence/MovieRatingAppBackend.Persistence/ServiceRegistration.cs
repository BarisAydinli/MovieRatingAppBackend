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
            opt.UseSqlServer(configuration.GetConnectionString("SqlServer"), builder =>
            {
                builder.EnableRetryOnFailure();
                builder.CommandTimeout(30);
            } );
            opt.EnableDetailedErrors();
            opt.EnableSensitiveDataLogging();
        });
        
        
        
        return services;
    }
}