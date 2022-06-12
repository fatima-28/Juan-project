using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DAL;

namespace Juan.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]

  
    public class DashboardController : Controller
    {
        public AppDbContext _context { get; set; }
        public DashboardController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
