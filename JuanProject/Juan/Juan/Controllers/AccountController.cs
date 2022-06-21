using Juan.Models;
using Juan.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juan.DAL;
namespace Juan.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager { get;  }
        private SignInManager<AppUser> _signinManager { get; }

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signinManager)
        {
            _userManager = userManager;
            _signinManager = signinManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM user)
        {
            if (!ModelState.IsValid) return View(user);

            AppUser newUser = new AppUser
            {
                Fullname = user.Fullname,
                UserName = user.Username,
                Email = user.Email
            };
            var identityResult = await _userManager.CreateAsync(newUser, user.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);

                }
                return View(user);
               await _signinManager.SignInAsync(newUser, true);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

    }
}
