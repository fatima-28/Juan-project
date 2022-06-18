﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DAL;

namespace Juan.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private AppDbContext _context { get; }
        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _context.Settings.ToDictionaryAsync(s => s.key, s => s.value);
            return View(model);
        }
    }
}