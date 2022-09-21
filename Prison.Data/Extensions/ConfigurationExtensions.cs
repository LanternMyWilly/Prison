using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Prison.Data;

namespace Stoelendans.Data
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PrisonDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Prison"), sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(maxRetryCount: 3, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                }
            ));
        }
    }
}
