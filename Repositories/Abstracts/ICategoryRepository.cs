using WebApplication1.Models.Entities;

namespace WebApplication1.Repositories.Abstracts
{
    public interface ICategoryRepository
    {
        public List<Category> GetCategories();
    }
}
