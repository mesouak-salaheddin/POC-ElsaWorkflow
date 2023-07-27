using Microsoft.AspNetCore.Mvc;

namespace Elsa_Project.Controllers
{
    public class ElsaDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
