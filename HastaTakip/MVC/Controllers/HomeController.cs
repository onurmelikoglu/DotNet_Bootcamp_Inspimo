using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // ~/Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // ~/Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // ~/Home/Error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // ~/Home/About
        // IActionResult // base'in implemente ettiði interface
        // |
        // ActionResult // base
        // |
        // ViewResult - ContentResult
        public ViewResult About()
        {
            //return new ViewResult();
            return View();
        }

        public ActionResult Contact()
        {
            //return new ViewResult();
            return View("Iletisim");
        }

        // ~/Home/Tarih
        public ContentResult Tarih()
        {
            //return new ContentResult()
            //{
            //    Content = "Bugünün tarihi: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss", new CultureInfo("tr_TR")),
            //    ContentType = "text/plain",
            //    StatusCode = 200 // OK: baþarýlý
            //};
            return Content("Bugünün tarihi: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), "text/plain", Encoding.UTF8);
        }

        // ~/Home/Baslik
        public IActionResult Baslik()
        {
            return Content("<p style=\"COLOR:BLUE;\">Hasta Takip</p>", "text/html");
        }

        // ~/Home/Microsoft
        public RedirectResult Microsoft()
        {
            // return new RedirectResult("https://google.com");
            return Redirect("https://google.com");
        }
    }
}
