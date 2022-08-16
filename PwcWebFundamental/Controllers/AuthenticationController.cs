using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace PwcWebFundamental.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username)
        {
            username = "Favour";

            var appClaim = new List<Claim>()
            { new Claim(ClaimTypes.Name,username) };

            var appIdentity = new ClaimsIdentity(appClaim, "App Identity");
            var userPrincipal = new ClaimsPrincipal(new[] { appIdentity });
            HttpContext.SignInAsync(userPrincipal);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
