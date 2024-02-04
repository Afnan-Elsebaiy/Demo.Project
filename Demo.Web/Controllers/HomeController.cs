using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class HomeController : Controller
    {
        //main Page
        public IActionResult Index()
        {
            return View();
        }
    }
}
