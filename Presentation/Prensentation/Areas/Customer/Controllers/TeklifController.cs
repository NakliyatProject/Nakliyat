using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class TeklifController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
