using Juan.Models;
using Juan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DAL;

namespace Juan.Controllers
{

    public class ShopController : Controller
    {
        private AppDbContext _context { get; }
        private int _count { get; }
        public ShopController(AppDbContext context)
        {
            _context = context;
            _count = _context.Products.Where(p => !p.IsDeleted).Count();
        }
        public IActionResult Index()
        {

            ViewBag.ProductCount = _count;
            ShopViewModel shop = new ShopViewModel
            {

                Categories = _context.Categories.Where(c => !c.IsDeleted).ToList(),
                Products = _context.Products.Where(c => !c.IsDeleted).OrderByDescending(p => p.Id).Skip(5).Take(9).ToList()
               


            };
            return View(shop);
        }

        public IActionResult LoadProducts( int skip=5)
        {
            if (skip>= _count)
            {
                return BadRequest();

            }
            List<Product> products = _context.Products.Where(p => !p.IsDeleted).OrderByDescending(p => p.Id).Skip(skip).Take(9).ToList();

            //return Json(products);
            return PartialView("_ProductPartial", products);
        }
    }
}
