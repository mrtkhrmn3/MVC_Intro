using WebApplication1.Data;
using WebApplication1.Models.Entities;
using WebApplication1.Repositories.Abstracts;

namespace WebApplication1.Repositories.Concretes
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories()
        {
            return CategoryData.Categories.ToList();
        }
    }
}
