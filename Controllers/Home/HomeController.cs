using Microsoft.AspNetCore.Mvc;

namespace FrontendMVC.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
