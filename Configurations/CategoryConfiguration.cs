using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Data;
using WebApplication1.Models.Entities;

namespace WebApplication1.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder) {

               builder.HasData(CategoryData.Categories);

        }
    }
}
