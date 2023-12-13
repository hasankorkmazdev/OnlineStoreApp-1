using Microsoft.AspNetCore.Mvc;
using OnlineStoreApp_2.Models;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace OnlineStoreApp_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<UrunModel> productList = new List<UrunModel>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            productList.Add(new UrunModel()
            {
                Id = 1,
                Piece = 3,
                Stars=5,
                Name = "Monster",
                ImageUrl= "https://picsum.photos/id/1/450/300",
                Price = 15555,
            });
            productList.Add(new UrunModel()
            {
                Id = 2,
                Piece = 5,
                Stars = 2,
                Name = "Lenovo",
                ImageUrl = "https://picsum.photos/id/2/450/300",
                Price = 12000,
            });
            productList.Add(new UrunModel()
            {
                Id = 3,
                Piece = 0,
                Stars = 1,
                Name = "Apple",
                ImageUrl = "https://picsum.photos/id/3/450/300",
                Price = 19999,
            });

        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View("Privacys");
        }
        public IActionResult ProductList()
        {
            //Veritabanından Ürünler alındı
            //Modele Eşlendi
            ViewBag.SystemStatus = "Çalışıyor";
            return View("ProductList", productList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}