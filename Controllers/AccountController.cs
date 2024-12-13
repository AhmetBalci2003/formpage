using formpage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

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
            Password ="",
            Reg_Date =null,
            Account_Status = true,
            Phone_Num ="",
            verify_email = false
        };

        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login_page()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> login_form(string email, string password, string action)
        {

            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    ViewBag.ErrorMessage = "E-posta ve şifre boş olamaz!";
                    return View("Login_page");
                }

                try
                {
                    _email=email;
                    string encryptedPassword = Base64Helper.Encode(password);

                    var user = await _context.Users
                      .Where(u => u.Email == email)
                      .FirstOrDefaultAsync();

                    if (user != null)
                    {
                        if (user.Password == encryptedPassword)
                        {

                            return RedirectToAction("success", "Account");
                        }
                        else
                        {
                            ViewBag.ErrorMessage = "Geçersiz şifre!";
                        }
                    }

                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = "giriş yapılırken bir hata oluştu:" + ex.Message;
                    return View("Login_page");



                }


            }

            return View("login_page");


        }

        public IActionResult register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> register_action(string Name, string S_name, string Email, string Password, string Phone_Num)
        {
            // Alanların boş olmaması kontrolü
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(S_name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Phone_Num))
            {
                ViewBag.ErrorMessage = "Tüm alanlar doldurulmalıdır!";
                return View("register");
            }

            try
            {
                // Aynı e-posta adresi ile kullanıcı kaydının yapılmasını engelleme
                var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == Email);
                if (existingUser != null)
                {
                    // Eğer e-posta adresi zaten kayıtlıysa hata mesajı göster
                    ViewBag.ErrorMessage = "Bu e-posta adresiyle zaten bir hesap bulunmaktadır.";
                    return View("register");
                }

                _email = Email;


                user.ID = Guid.NewGuid().ToString();
                user.Name = Name;
                user.S_Name = S_name;
                user.Email = Email;
                user.Password = Base64Helper.Encode(Password);
                user.Reg_Date = DateTime.Now;
                user.Phone_Num = Phone_Num;


                // Veritabanına kaydet


                // Kayıt işlemi başarılı, kullanıcıyı doğrulama sayfasına yönlendir
                return RedirectToAction("verify", "Account");
            }
            catch (Exception ex)
            {
                // Hata durumunda tekrar kayıt sayfasını göster
                ViewBag.ErrorMessage = "Bir hata oluştu. Lütfen tekrar deneyin.";
                return View("register");
            }
        }

        public IActionResult success()
        {
            return View();
        }
        public void verify_fun(string email)
        {

            Verify_email vcode = new Verify_email();
            _code = vcode.Send_email(email);

        }
        public IActionResult verify()
        {


            if (_code == "")
            {
                verify_fun(_email);
            }
            return View();
        }

        [HttpPost]
        public IActionResult VerifyAction(string code)
        {
            if (code.ToString() == _code)
            {
                user.verify_email=true;

                if (user != null)
                {
                    _context.Add(user);
                    _context.SaveChangesAsync();
                }
                else
                {
                    return RedirectToAction("verify");
                }

                return RedirectToAction("Login_page");
            }
            else
            {
                ViewBag.ErrorMessage = "Geçersiz doğrulama kodu. Lütfen tekrar deneyin.";


                return View("Verify");
            }
        }

        public IActionResult ResendCode()
        {

            _code="";
            verify_fun(_email);
            return RedirectToAction("verify");


        }

    }

}


