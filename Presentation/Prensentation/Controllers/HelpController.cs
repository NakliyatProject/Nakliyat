using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
