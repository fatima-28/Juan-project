using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DAL;
using WebApp.ViewModels;

namespace Juan.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {


            HomeViewModel home = new HomeViewModel
            {

                Categories = _context.Categories.Where(c => !c.IsDeleted).ToList(),
                Products = _context.Products.Where(c => !c.IsDeleted).ToList(),
                Slides = _context.Slides.ToList(),
                Futures = _context.Futures.Where(f => !f.IsDeleted).ToList(),
                NewProducts = _context.NewProducts.Where(np => !np.IsDeleted).ToList(),
                OurBlogs = _context.OurBlogs.Where(blog => !blog.IsDeleted).ToList()
               

            };
            return View(home);
        }
    }
}
