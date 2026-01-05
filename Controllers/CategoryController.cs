using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contexts;
using WebApplication1.Data;
using WebApplication1.Repositories.Abstracts;
using WebApplication1.Utils;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository= categoryRepository;
        }
        public IActionResult Index()
        {
            var categories = _categoryRepository.GetCategories();
            return View();
        }
    }
}
