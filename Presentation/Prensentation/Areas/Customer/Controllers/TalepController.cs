using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class TalepController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}