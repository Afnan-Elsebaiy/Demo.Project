using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
