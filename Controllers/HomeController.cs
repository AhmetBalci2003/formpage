using formpage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace formpage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public IActionResult login_form(string email, string password, string action)
        {
            if (action == "login") // Giri� i�lemi
            {
                

                
            }
            else if (action == "register") // Kay�t i�lemi
            {
                return RedirectToAction("register");
            }

            return View("login_page"); // Giri� sayfas�na y�nlendirme
        }


        public IActionResult succes()
        {
            return View();
        }

        public IActionResult login_page()
        {
            return View();
        }
        public IActionResult register()
        {
            return View();
        }









    }
}
