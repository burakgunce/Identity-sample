using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WA_IdentityApplicationSample_080124.Models;

namespace WA_IdentityApplicationSample_080124.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        UserManager<AppUser> userManager;
        SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager)
        {
            this.userManager = _userManager;
            this.signInManager = _signInManager;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            Login login = new Login();
            login.ReturnUrl = returnUrl;
            return View(login);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
