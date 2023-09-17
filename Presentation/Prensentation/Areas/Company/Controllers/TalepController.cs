using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Areas.Company.Controllers
{
    [Area("Company")]
    public class TalepController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public TalepController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult AkistakiTalepler()
        {
            var talepler = _serviceManager.TasimaTalebiService.GetAll();
            return View(talepler);
        }

        public IActionResult GetTalep([FromRoute(Name = "id")] Guid id)
        {
            var talep = _serviceManager.TasimaTalebiService.GetAll().Where(t=>t.Id.Equals(id)).FirstOrDefault();
            return View(talep);
        }
    }
}
