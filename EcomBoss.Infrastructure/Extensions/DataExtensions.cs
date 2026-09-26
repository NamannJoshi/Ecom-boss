using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EcomBoss.Infrastructure.Extensions;

public static class DataExtensions
{
    public static IServiceCollection AddDatabase(
        this IServiceCollection services,
        IConfiguration config
    )
    {
        return services
            .AddDbContext<AppDbContext>(
                options => options.UseNpgsql(config.GetConnectionString("AppDb"))
                );
    }
}
