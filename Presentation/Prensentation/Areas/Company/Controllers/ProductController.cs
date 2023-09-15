using Application.Service;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace Prensentation.Areas.Company.Controllers
{
    [Area("Company")]
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.UserService.GetAll(false);
            return View(model);
        }
      
        private SelectList GetCategoriesSelectList()
        {
            return new SelectList(_manager.UserService.GetAll(false),
            "CategoryId",
            "CategoryName", "1");

        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = GetCategoriesSelectList();

            return View();
        }


        [HttpGet]
        public IActionResult Create2(int id)
        {
            ViewBag.Categories = GetCategoriesSelectList2();

            return View();

        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] User user, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                // file operation
                //string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);

                //using (var stream = new FileStream(path, FileMode.Create))
                //{
                //    await file.CopyToAsync(stream);
                //}

                //user.ImageUrl = String.Concat("/images/", file.FileName);

                await _manager.UserService.AddAsync(user);
                return RedirectToAction("Index");
            }
            return View();
        }
        private SelectList GetCategoriesSelectList2()
        {
            return new SelectList(_manager.UserService.GetAll(false),
            "CategoryId",
            "CategoryName", "1");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create2([FromForm] User user, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                // file operation
                //string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);

                //using (var stream = new FileStream(path, FileMode.Create))
                //{
                //    await file.CopyToAsync(stream);
                //}

                //user.ImageUrl = String.Concat("/images/", file.FileName);

                await _manager.UserService.AddAsync(user);
                return RedirectToAction("Index");
            }
            return View();
        }


        //[HttpGet]
        //public IActionResult Update2(int id)
        //{
        //    var specs = _manager.UserService.GetUpdateProductSpecs(id);

        //    UpdateProductVM viewModel = new UpdateProductVM(specs);

        //    return View(viewModel);
        //}
        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            //ViewBag.Categories = GetCategoriesSelectList();
            //var model = _manager.UserService.UpdateData(id, false);
            //return View(model);
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Update([FromForm] User user, IFormFile file)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //// file operation
        //        //string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);

        //        //using (var stream = new FileStream(path, FileMode.Create))
        //        //{
        //        //    await file.CopyToAsync(stream);
        //        //}

        //        //productDto.ImageUrl = String.Concat("/images/", file.FileName);

        //        _manager.UserService.UpdateData(user);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Update2([FromRoute(Name = "id")] int id, [FromForm] UpdateProductVM viewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (viewModel.file != null)
        //        {
        //            // file operation
        //            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", viewModel.file.FileName);

        //            using (var stream = new FileStream(path, FileMode.Create))
        //            {
        //                await viewModel.file.CopyToAsync(stream);
        //            }

        //            viewModel.ImageUrl = String.Concat("/images/", viewModel.file.FileName);
        //        }


        //        _manager.ProductService.UpdateProduct(viewModel);
        //        return RedirectToAction("Index");
        //    }

        //var specs = _manager.ProductService.GetUpdateProductSpecs(id);
        //    viewModel.SetSpecs(specs);

        //    return View(viewModel);
        //}

        [HttpGet]
        public IActionResult Delete([FromRoute(Name = "id")] Guid id)
        {
            var users = _manager.UserService.GetAll(); 
            _manager.UserService.Remove(users.Where(u=>u.Id==id).FirstOrDefault());
            return RedirectToAction("Index");
        }

    }
}