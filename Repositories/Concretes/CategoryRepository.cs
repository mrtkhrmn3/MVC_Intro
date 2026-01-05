using WebApplication1.Models.Entities;
using WebApplication1.Repositories.Abstracts;
using WebApplication1.Utils;

namespace WebApplication1.Repositories.Concretes
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories()
        {
            return DatabaseSingleton.Context.Categories.ToList();
        }
    }
}
