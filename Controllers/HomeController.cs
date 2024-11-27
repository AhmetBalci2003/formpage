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
            if (action == "login") // Giriþ iþlemi
            {
                

                
            }
            else if (action == "register") // Kayýt iþlemi
            {
                return RedirectToAction("register");
            }

            return View("login_page"); // Giriþ sayfasýna yönlendirme
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
