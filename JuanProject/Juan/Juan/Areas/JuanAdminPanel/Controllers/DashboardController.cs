using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Areas.JuanAdminPanel.Controllers
{
    [Area("JuanAdminPanel")] //Admin panel is not working yet
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
