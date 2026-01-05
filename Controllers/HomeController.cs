using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Anasayfa";
        //}

        public IActionResult Index()
        {
            List<string> list = new List<string>
            {
                "Data1","Data2","Data3"
            };
            //Model transfer

            return View(list);
        }

        //public string About()
        //{
        //    return "Hakkımızda";
        //}

        //public string Contact()
        //{
        //    return "İletişim";
        //}


        //get
        public IActionResult Contact()
        {
            return View();
        }

        //post
        [HttpPost]
        public IActionResult Contact(string message, string email, string firstname)
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
