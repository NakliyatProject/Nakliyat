using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Areas.Company.Controllers
{
    [Area("Company")]
    public class CustomerController : Controller
    {
        private readonly IServiceManager _manager;

        public CustomerController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var models = _manager.UserService.GetAll();
            return View(models);
        }
    }
}