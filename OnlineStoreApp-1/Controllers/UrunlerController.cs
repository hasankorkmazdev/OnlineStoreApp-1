using Microsoft.AspNetCore.Mvc;
using OnlineStoreApp_1.DataModel;
using OnlineStoreApp_1.Models;
using System.Diagnostics;

namespace OnlineStoreApp_1.Controllers
{
    public class UrunlerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //List<> _keyValuePairs = new List<Dictionary<string,string>>();

        List<Dictionary> menuItem = new List<Dictionary>();
        List<UrunEntity> veritabanındakiBilgisayarUrunleri = new List<UrunEntity>();
        string kullaniciAdi = "Hasan KORKMAZ";
        public UrunlerController(ILogger<HomeController> logger)
        {


            menuItem.Add(new Dictionary()
            {
                Key = "Bilgisayar Ürünleri",
                Value = "/Urunler/Bilgisayar"
            });
            menuItem.Add(new Dictionary()
            {
                Key = "Ev Yaşam",
                Value = "/Urunler/EvYasam"
            });
            menuItem.Add(new Dictionary()
            {
                Key = "Kozmetik",
                Value = "/Urunler/Kozmetik"
            });

            veritabanındakiBilgisayarUrunleri.Add(new UrunEntity()
            {
                Id = 1,
                Adet = 2,
                Adi = "Lenovo IdeaPad 3 15IAU7 Intel Core i3 1215U 8GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar 82RK00XATX\r\nLenovo",
                Fiyat = 25000,
                Kategori = "Laptop",
            });
            veritabanındakiBilgisayarUrunleri.Add(new UrunEntity()
            {
                Id = 2,
                Adet = 3,
                Adi = "Monster",
                Fiyat = 15555,
                Kategori = "Laptop",
            });
            veritabanındakiBilgisayarUrunleri.Add(new UrunEntity()
            {
                Id = 3,
                Adet = 6,
                Adi = "Macbook Air",
                Fiyat = 15555,
                Kategori = "Laptop",
            });
            _logger = logger;
        }


        public IActionResult Index()
        {
            ViewBag.Menu = menuItem;
            ViewBag.KullaniciAdi = kullaniciAdi;

            return View();
        }

        public IActionResult Urun()
        {
            var perwol = new UrunViewModel()
            {
                Adi = "Perwol",
                Adet = 10,
                Fiyat = 55
            };

            ViewBag.Menu = menuItem;
            ViewBag.KullaniciAdi = kullaniciAdi;

            return View(perwol);
        }
        public IActionResult EvYasam()
        {
            var saksi = new UrunViewModel()
            {
                Adi = "Saksi",
                Adet = 1,
                Fiyat = 5
            };
            ViewBag.Menu = menuItem;
            ViewBag.KullaniciAdi = kullaniciAdi;

            return View("Urun", saksi);

        }
        public IActionResult Kozmetik()
        {
            return View("Kozmetik");

        }
        public IActionResult Bilgisayar()
        {
            ViewBag.Menu = menuItem;
            ViewBag.KullaniciAdi = kullaniciAdi;

            return View("UrunleriListele", veritabanındakiBilgisayarUrunleri);
        }
        public IActionResult UrunDetay(int id)
        {
            ViewBag.Menu = menuItem;
            ViewBag.KullaniciAdi = kullaniciAdi;
            UrunEntity duzenlenecekUrun = null;

            foreach (var item in veritabanındakiBilgisayarUrunleri)
            {
                if (item.Id==id)
                {
                    duzenlenecekUrun = item;
                }
            }

            return View("UrunDetay",duzenlenecekUrun);
        }
    }

}