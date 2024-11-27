using formpage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace formpage.Controllers
{
    public class AccountController : Controller
    {
        
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
                if (action == "login")
                {
                   if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                   {
                       ViewBag.ErrorMessage = "E-posta ve şifre boş olamaz!";
                       return View("Login_page");
                   }

                try
                {
                    string encryptedPassword = Base64Helper.Encode(password);

                    var user = await  _context.Users
                      .Where(u => u.Email == email)
                      .Where( u=> u.Password==encryptedPassword)
                      .FirstOrDefaultAsync();

                }
                catch (Exception ex)
                {

                   

                }


                           













                }
                else if (action == "register")
                {
                    return RedirectToAction("register");
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
                
                
                    // Yeni kullanıcı oluştur
                    var user = new User
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name =  Name,
                        S_Name = S_name,
                        Email = Email,
                        Password = Base64Helper.Encode(Password),
                        Reg_Date = DateTime.Now,
                        Account_Status = true,
                        Phone_Num = Phone_Num,
                        Last_Log_Date = null
                    };

                    // Veritabanına kaydet
                    _context.Add(user);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("login_page", "Account");
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = "Kayıt sırasında bir hata oluştu: " + ex.Message;
                    return View("register");
                }
            }
        
    }

}


