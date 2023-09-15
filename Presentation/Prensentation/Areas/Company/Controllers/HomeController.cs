using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Areas.Company.Controllers
{
    [Area("Company")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }    
}