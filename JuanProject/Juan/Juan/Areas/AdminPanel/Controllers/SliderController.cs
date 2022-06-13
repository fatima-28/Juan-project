using Juan.Helpers;
using Juan.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DAL;

namespace Juan.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SliderController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {

            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Slides);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slide slide)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (slide.Photo.CheckFileSize(200))
            {

                ModelState.AddModelError("Photo", "Image size error ");
                return View();

            }
            if (!slide.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "type error ");
                return View();
            }


            slide.Image = await slide.Photo.SaveFileAsync(_env.WebRootPath, "img");

            await _context.Slides.AddAsync(slide);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();

            }
            var slider = _context.Slides.Find(id);
            if (slider == null)
            {
                return NotFound();
            }
            var path = Helper.GetPath(_env.WebRootPath, "img", slider.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);

            }
            _context.Slides.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var DBSlide = _context.Slides.Find(id);
            return View(DBSlide);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateAsync(int? id, Slide slide)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var DBSlide = _context.Slides.Find(id);
            if (DBSlide == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!slide.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Image size error");
                return View();
            }
            if (!slide.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type error exist");
                return View();
            }
            slide.Image = await slide.Photo.SaveFileAsync(_env.WebRootPath, "img", "slider");
            var path = Helper.GetPath(_env.WebRootPath, "img", "slider", DBSlide.Image);
            DBSlide.Image = slide.Image;
          

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


    }
}
