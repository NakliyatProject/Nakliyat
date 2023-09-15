//using Entities.Dtos;
//using Microsoft.AspNetCore.Mvc.Rendering;

//namespace StoreApp.Areas.Customer.ViewModels
//{

//    public record UpdateProductVM : UpdateProductRequest
//    {

//        //public IFormFile? file { get; set; }

//        public SelectList? Categories { get; set; }

//        public UpdateProductVM() { }

//        public UpdateProductVM(UpdateProductSpecs specs)
//        {
//            ProductId = specs.Product.ProductId;
//            ProductName = specs.Product.ProductName;
//            Price = specs.Product.Price;
//            Summary = specs.Product.Summary;
//            ImageUrl = specs.Product.ImageUrl;
                

//            Categories = new SelectList(specs.Categories,
//                "CategoryId",
//                "CategoryName", CategoryId);
//        }

//        public void SetSpecs(UpdateProductSpecs specs)
//        {

//            if (string.IsNullOrEmpty(ImageUrl))
//                ImageUrl = specs.Product.ImageUrl;

//            Categories = new SelectList(specs.Categories,
//                "CategoryId",
//                "CategoryName", CategoryId);
//        }
//    }

//}

