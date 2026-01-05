using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexts;
using WebApplication1.DependencyResolver;

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

            builder.Services.AddDbContextService();

            //Services
            builder.Services.AddMvc();

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