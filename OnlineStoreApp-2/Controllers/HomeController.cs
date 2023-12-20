using Microsoft.AspNetCore.Mvc;
using OnlineStoreApp_2.Data;
using OnlineStoreApp_2.Data.Context;
using OnlineStoreApp_2.Models;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace OnlineStoreApp_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;


        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View("Privacys");
        }
        public IActionResult NewProduct()
        {
            return View();
        }

        public IActionResult SaveProduct(ProductModel model)
        {
            try
            {
                ProductEntity productEntity = new ProductEntity();
                productEntity.Stars = model.Stars;
                productEntity.Name = model.Name;
                productEntity.ImageUrl = model.ImageUrl;
                productEntity.Piece = model.Piece;
                productEntity.Price = model.Price;
                productEntity.CategoryId = model.CategoryId;
                OnlineStoreDBContext database = new OnlineStoreDBContext();
                database.Products.Add(productEntity);
                database.SaveChanges();
                return View("Success");

            }
            catch (Exception ex)
            {
                return View("Fail");
            }
           
        }

        public IActionResult ProductList()
        {
            //Veritabanından Ürünler alındı
            //Modele Eşlendi
            OnlineStoreDBContext database = new OnlineStoreDBContext();
            var productListEntities = database.Products.ToList();
            var productModelList = new List<ProductModel>();
            foreach (var item in productListEntities)
            {
                productModelList.Add(new ProductModel()
                {
                    Id = item.Id,
                    ImageUrl = item.ImageUrl,
                    Name = item.Name,
                    Piece = item.Piece,
                    Price = item.Price,
                    Stars = item.Stars
                });
            }
            ViewBag.SystemStatus = "Çalışıyor";
            return View("ProductList", productModelList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}