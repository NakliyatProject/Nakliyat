using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace Prensentation.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class MessagesController : Controller
    {
        private readonly IServiceManager _manager;

        public MessagesController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var users = _manager.CustomerService.GetAll();
            return View(users);
        }

        [HttpPost]
        public IActionResult Complete([FromForm]int id)
        {
            //_manager.UserService.Complete(id);
            return RedirectToAction("Index");
        }
    }
}