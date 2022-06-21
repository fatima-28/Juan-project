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
        private UserManager<AppDbContext> _userManager { get;  }

        public AccountController(UserManager<AppDbContext> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterVM user)
        {
            if (!ModelState.IsValid) return View(user);

            return View();
        }

    }
}
