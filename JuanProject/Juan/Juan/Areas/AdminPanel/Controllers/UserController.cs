using Juan.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class UserController : Controller
    {
        private UserManager<AppUser> _users { get; }
        public UserController(UserManager<AppUser> users)
        {
            _users = users;

        }

        public IActionResult Index()
        {
            var AllUsers = _users.Users.ToList();
            return View(AllUsers);
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var user = await _users.FindByIdAsync(id);
            
            AppUser userDb = _users.Users.FirstOrDefault(u => u.Id == id);
            if (userDb == null)
            {
                return NotFound();
            }
            await _users.DeleteAsync(user);
           
            return RedirectToAction(nameof(Index));

        }
    }
}
