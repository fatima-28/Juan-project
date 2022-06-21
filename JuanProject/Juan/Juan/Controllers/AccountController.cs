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
               
            }
            await _signinManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult SignIn()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< IActionResult >SignIn(SignInVM user)
        {
         AppUser userDb= await  _userManager.FindByEmailAsync(user.Email);
            if (userDb==null)
            {
                ModelState.AddModelError("","Email or password is not valid");
                return View(user);
            }

            var signinResult =
                await _signinManager.PasswordSignInAsync(userDb.Email,user.Password,user.IsPersistent,lockoutOnFailure:true);
            if (signinResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Please try after few minute");
                return View(user);
            }
            if (!signinResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password is not valid");
                return View(user);
            }
            if (!userDb.IsActivated)
            {
                ModelState.AddModelError("", "Verify your account");
                return View(user);
            }
            return View();

        }
    }
}
