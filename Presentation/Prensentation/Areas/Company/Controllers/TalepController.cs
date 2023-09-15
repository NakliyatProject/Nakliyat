using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Areas.Company.Controllers
{
    [Area("Company")]
    public class TalepController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}