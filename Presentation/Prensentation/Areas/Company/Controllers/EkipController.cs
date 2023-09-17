using Application.Service;
using Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Areas.Company.Controllers
{
    [Area("Company")]
    public class EkipController : Controller
    {
        private readonly IServiceManager _manager;

        public EkipController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var ekipler = _manager.EkipService.GetAll();
            return View(ekipler);
        }


        [HttpGet]
        public IActionResult CreatePage()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePage([FromBody] EkipDto model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                // file operation
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                model.AracImgUrl = string.Concat("/images/", file.FileName);
                await _manager.EkipService.AddAsync(model);
                await _manager.EkipService.SaveAsync();
                return RedirectToAction("Company/Ekip/Index");
            }
            return View();
        }
    }
}
