using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("Data Source=(localdb)\\localdb;Initial Catalog='SchoolSystem'",
                x => x.MigrationsHistoryTable("__EFMigrationsHistory", "SchoolSystem")));

            return services;
        }
    }
}
