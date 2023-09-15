//using Entities.Dtos;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using System.ComponentModel.DataAnnotations;

//namespace StoreApp.Areas.Customer.ViewModels
//{
//    public record CreateProductVM : CreateProductRequest
//    {
//        public IFormFile? ImageFile { get; set; }
//        public int SelectedCategoryId { get; set; }
//        public SelectList Categories { get; set; }

//        CreateProductVM() { }

//        CreateProductVM(CreateProductSpecs specs)
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

//        public void SetSpecs(CreateProductSpecs specs)
//        {

//            if (string.IsNullOrEmpty(ImageUrl))
//                ImageUrl = specs.Product.ImageUrl;

//            Categories = new SelectList(specs.Categories,
//                "CategoryId",
//                "CategoryName", CategoryId);
//        }

//    }
//}


