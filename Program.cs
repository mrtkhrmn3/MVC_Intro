using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexts;
using WebApplication1.DependencyResolver;
using WebApplication1.Repositories.Abstracts;
using WebApplication1.Repositories.Concretes;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Model View Controller

            //Controller:
            //View:
            //Model:
            var builder = WebApplication.CreateBuilder(args);



            //Services
            builder.Services.AddMvc();

            builder.Services.AddDbContextService();

            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<ICategoryRepository, FakeCategoryRepository>();

            var app = builder.Build();

         


            // /contact => İletişim sayfası
            // /about => Hakkımızda sayfası
            app.MapGet("/contact", () => "İletişim");
            app.MapGet("/about", () => "Hakkımızda");

            //Routing
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute(); // Home/Index/id(opsiyonel)
            });
            //pipeline
            
            app.Run();
        }
    }
}