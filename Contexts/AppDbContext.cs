using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
      

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Elektronik", Description = "Elektronik ürünler" },
                new Category { Id = 2, Name = "Bilgisayar", Description = "Bilgisayar ve aksesuarları" },
                new Category { Id = 3, Name = "Telefon", Description = "Akıllı telefonlar" },
                new Category { Id = 4, Name = "Ev Aletleri", Description = "Beyaz eşya ve küçük ev aletleri" },
                new Category { Id = 5, Name = "Kitap", Description = "Kitap ve dergiler" },
                new Category { Id = 6, Name = "Giyim", Description = "Kadın ve erkek giyim" },
                new Category { Id = 7, Name = "Ayakkabı", Description = "Spor ve klasik ayakkabılar" },
                new Category { Id = 8, Name = "Spor", Description = "Spor malzemeleri" },
                new Category { Id = 9, Name = "Kozmetik", Description = "Kozmetik ve kişisel bakım" },
                new Category { Id = 10, Name = "Oyuncak", Description = "Çocuk oyuncakları" }
            );
        }

    }
}
