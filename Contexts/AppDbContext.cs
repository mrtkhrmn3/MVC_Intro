using Microsoft.EntityFrameworkCore;
using WebApplication1.Configurations;
using WebApplication1.Models.Entities;

namespace WebApplication1.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
      

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }

    }
}
