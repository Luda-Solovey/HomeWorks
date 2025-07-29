using _12_AutentificationAvtorization.DataBase;
using _12_AutentificationAvtorization.Models;
using _12_AutentificationAvtorization.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace _12_AutentificationAvtorization.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model) 
        {
            if (ModelState.IsValid)
            {
              //  bool isUsedLoginFree = DataBaseUsers.Users.Select(user => user.Login).Contains(model.Login); //Не змогла виправити цю помилку
                bool isLoginAlreadyUsed = DataBaseUsers.Users.Any(x => x.Login == model.Login);
                if (isLoginAlreadyUsed)
                {
                    ModelState.AddModelError(nameof(model.Login), "Login already exist. Please, use some another one.");
                    return View(model);
                }

                var newUser = new UsersViewModel()
                {
                    Id = Guid.NewGuid(),
                    Login = model.Login,
                    PasswordHash = ServiceForPassword.HashPassword(model.Password)
                };
                DataBaseUsers.Users.Add(newUser);
                return View("SuccessfulyRegistered");
            }
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginViewModel model) 
        {
            if (ModelState.IsValid)
            { 
                //дістаємо юзера (і всі його дані) з бази, якщо він там є
                var userOrNull = DataBaseUsers.Users.FirstOrDefault(x => x.Login == model.Login);
                if (userOrNull is UsersViewModel user) 
                {
                    var isCorrectPassword = ServiceForPassword.IsPasswordCorrect(userOrNull, model.Password);
                    if (isCorrectPassword) 
                    {
                        await SignInAsync(user);
                        //return View("Home", "Index"); так не працює
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError(nameof(model.Login), "Wrong login or password");
                return View(model);
            }
            return View(model);
        }
        private async Task SignInAsync(UsersViewModel user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Login),
                new Claim(ClaimTypes.Role, "User"),
            };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(claimsPrincipal);
        }

        public async new Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
