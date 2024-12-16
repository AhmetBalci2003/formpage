using Microsoft.AspNetCore.Mvc;

namespace formpage.Controllers
{
    public class CustomController : Controller
    {
        public IActionResult homepage()
        {
            return View(); // Bu action, Homepage.cshtml sayfasını döndürür
        }



        // Hakkımızda action'ı (GET)
        [HttpGet]
        public IActionResult Hakkimizda()
        {
            return View("~/Views/Custom/hakkımızda.cshtml");
        }
    }
}
