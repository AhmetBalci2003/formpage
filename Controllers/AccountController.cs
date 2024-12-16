using formpage.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace formpage.Controllers
{
    public class AccountController : Controller
    {
        public static string _code = "";
        public static string _email = "";
        public static User user = new User
        {
            ID = "",
            Name = "",
            S_Name = "",
            Email = "",
            Password = "",
            Reg_Date = null,
            Account_Status = true,
            Phone_Num = "",
            verify_email = false
        };

        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Login sayfası
        public IActionResult Login_page()
        {
            return View();
        }

        // Login formunu işleyen POST metodu

        [HttpPost]
        public async Task<IActionResult> login_form(string email, string password, string action)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ViewBag.ErrorMessage = "E-posta ve şifre boş olamaz!";
                return View("Login_page");
            }

            try
            {
                _email = email;  // E-posta adresini global değişkende saklıyoruz.
                string encryptedPassword = Base64Helper.Encode(password);  // Şifreyi şifrele

                user = await _context.Users
                                     .Where(u => u.Email == email)
                                     .FirstOrDefaultAsync();

                if (user != null)
                {
                    if (user.Password == encryptedPassword)
                    {


                        return RedirectToAction("success", "Account");  // Başarılı giriş sonrası yönlendirme
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Geçersiz şifre!";
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "Kullanıcı bulunamadı!";
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Giriş yapılırken bir hata oluştu: " + ex.Message;
            }

            return View("Login_page");  // Hata durumunda tekrar giriş sayfasına döner
        }



        // Kayıt sayfası
        public IActionResult Register()
        {
            return View();
        }

        // Kayıt işlemi POST metodu
        [HttpPost]
        public async Task<IActionResult> Register_action(string Name, string S_name, string Email, string Password, string Phone_Num)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(S_name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Phone_Num))
            {
                ViewBag.ErrorMessage = "Tüm alanlar doldurulmalıdır!";
                return View("Register");
            }

            try
            {
                var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == Email);
                if (existingUser != null)
                {
                    ViewBag.ErrorMessage = "Bu e-posta adresiyle zaten bir hesap bulunmaktadır.";
                    return View("Register");
                }

                _email = Email;
                user.ID = Guid.NewGuid().ToString();
                user.Name = Name;
                user.S_Name = S_name;
                user.Email = Email;
                user.Password = Base64Helper.Encode(Password);
                user.Reg_Date = DateTime.Now;
                user.Phone_Num = Phone_Num;
                _code = "";





                return RedirectToAction("verify");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Bir hata oluştu. Lütfen tekrar deneyin. Hata: " + ex.Message;
                return View("Register");
            }
        }


        // Başarı sayfası
        public IActionResult success()
        {

            // Kullanıcı bilgilerini ViewBag'e ekleyin
            ViewBag.UserName = user.Name;
            ViewBag.UserSurname =user.S_Name;

            return View();
        }

        // E-posta doğrulama işlemi
        public void Verify_fun(string email)
        {
            Verify_email vcode = new Verify_email();
            _code = vcode.Send_email(email);
        }

        // Doğrulama sayfası
        public IActionResult Verify()
        {

            if (_code == "")
            {

                Verify_fun(_email);
            }


            return View();
        }

        // Doğrulama kodunu işleyen POST metodu

        [HttpPost]
        public IActionResult VerifyAction(string code1, string code2, string code3, string code4)
        {
            try
            {
                // Gelen değerlerin null veya boş olmadığını kontrol et
                if (string.IsNullOrEmpty(code1) || string.IsNullOrEmpty(code2) ||
                    string.IsNullOrEmpty(code3) || string.IsNullOrEmpty(code4))
                {
                    ViewBag.ErrorMessage = "Lütfen tüm kod alanlarını doldurun!";
                    return View("verify");
                }

                // Kodları birleştir
                string verificationCode = $"{code1}{code2}{code3}{code4}";


                // Doğrulama işlemi (_code global değişkeninden alınıyor)
                if (verificationCode == _code)
                {
                    user.verify_email = true;
                    // Başarılı doğrulama işlemi
                    if (user != null)
                    {
                        _context.Add(user);
                        _context.SaveChangesAsync();
                        return RedirectToAction("Login_page");
                    }
                    else
                    {
                        return RedirectToAction("Verify");

                    }


                }
                else
                {
                    ViewBag.ErrorMessage = "Geçersiz doğrulama kodu. Lütfen tekrar deneyin.";


                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Bir hata oluştu: " + ex.Message;
            }

            return View("Verify");
        }


        // Doğrulama kodunu yeniden göndermek için
        public IActionResult ResendCode()
        {
            _code = "";  // Eski kodu sıfırla
            Verify_fun(_email);  // Yeni kodu oluştur
            return RedirectToAction("Verify");
        }

        // Çıkış işlemi
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();  // Kullanıcıyı çıkart
            return RedirectToAction("Login", "Account");  // Login sayfasına yönlendir
        }

    }
}