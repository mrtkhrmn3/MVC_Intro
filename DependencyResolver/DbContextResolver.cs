using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexts;

namespace WebApplication1.DependencyResolver
{
    public static class DbContextResolver
    {
        public static void AddDbContextService(this IServiceCollection services)
        {
            ServiceProvider provider = services.BuildServiceProvider();
            IConfiguration configuration = provider.GetRequiredService<IConfiguration>();

            services.AddDbContext<AppDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
