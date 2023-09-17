using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Controllers
{
    public class TalepController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public TalepController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult MevcutTalepler()
        {
            var talepler = _serviceManager.TasimaTalebiService.GetAll();
            return View(talepler);
        }
    }
}
