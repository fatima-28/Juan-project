﻿using Juan.Models;
using Juan.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DAL;

namespace Juan.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        public AppDbContext _context { get;  }
        private IEnumerable<Category> categories;
        public CategoryController(AppDbContext context)
        {
            _context = context;
            categories = _context.Categories.Where(c => !c.IsDeleted);
        }
        public IActionResult Index()
        {
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CategoryCreateViewModel category)
        {
           

            if (!ModelState.IsValid)
            {
                return View();

            }
            bool IsExist = categories.Where(c => !c.IsDeleted).Any(c => c.Name.ToLower() == category.Name.ToLower());
            if (IsExist)
            {
                ModelState.AddModelError("Name", $"{category.Name} is already exist!");
                return View();

            }
            Category newCategory = new Category()
            {
                Name = category.Name

            };
            await _context.Categories.AddAsync(newCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
