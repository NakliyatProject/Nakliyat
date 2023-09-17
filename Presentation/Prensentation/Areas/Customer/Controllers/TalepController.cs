using Application.Service;
using Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class TalepController : Controller
    {

        private readonly IServiceManager _manager;

        public TalepController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([FromForm] TasimaTalebiDto tasimaTalebiDto, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                // file operation
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                tasimaTalebiDto.EsyaImgUrl = string.Concat("/images/", file.FileName);

                await _manager.TasimaTalebiService.AddAsync(tasimaTalebiDto);
                await _manager.TasimaTalebiService.SaveAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}