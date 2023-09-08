using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Controllers
{
    public class UserController : Controller
    {
        private readonly IServiceManager _manager;

        public UserController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var models = _manager.UserService.GetAll();
            return View(models);
        }

        public async Task<IActionResult> Get([FromRoute(Name = "id")] Guid id)
        {
            var filteredModel = await _manager.UserService.GetByIdAsync(id.ToString());
            return View(filteredModel);
        }

        //public IActionResult Update([FromRoute(Name = "id")] Guid id)
        //{
        //    var filteredModel = _manager.UserService.GetByIdAsync(id.ToString());
        //    return View(filteredModel);
        //}

        //public IActionResult Delete([FromRoute(Name = "id")] Guid id)
        //{
        //    _manager.UserService.GetByIdAsync(id.ToString());
        //    return RedirectToAction("Index");
        //}
    }
}
