using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HelpPage()
        {
            return View();
        }
    }    
}