using Juan.Helpers;
using Juan.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juan.DAL;

namespace Juan.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SliderController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        private int counter { get; }
        private int SliderMaxCount { get; }
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {

            _context = context;
            _env = env;
            counter= _context.Slides.Count();
            SliderMaxCount=int.Parse( _context.Settings.ToDictionary(s => s.key, s => s.value)["slider_max_count"]);
        }
        public IActionResult Index()
        {
            ViewBag.count = counter;
            ViewBag.SliderMaxCount = SliderMaxCount;
            return View(_context.Slides);
        }
        public IActionResult Create()
        {
            if (counter>= SliderMaxCount)
            {
                return Content("sorry");
            }

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
            if (slide.Photos.Count+counter> SliderMaxCount)
            {
                ModelState.AddModelError("",$" you can choose {SliderMaxCount - counter} photo");
                return View();

            }
            string errormessage = string.Empty;
            foreach (var photo in slide.Photos)
            {
                if (!photo.CheckFileType("image/"))
                {
                   errormessage+= $"{photo.FileName} is not image type \n ";

                   
                }

                if (photo.CheckFileSize(200))
                {

                   errormessage+= $"{photo.FileName}Image has a size error \n ";

                } 
            }
            if (errormessage!=String.Empty)
            {
                ModelState.AddModelError("Photos",errormessage);
                return View();
            }
            foreach (var photo in slide.Photos)
            {
                Slide newslide = new Slide();
                newslide.Image = await photo.SaveFileAsync(_env.WebRootPath, "img");
                await _context.Slides.AddAsync(newslide);

            }
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
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> UpdateAsync(int? id, Slide slide)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest();
        //    }
        //    var DBSlide = _context.Slides.Find(id);
        //    if (DBSlide == null)
        //    {
        //        return NotFound();
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    if (!slide.Photo.CheckFileSize(200))
        //    {
        //        ModelState.AddModelError("Photo", "Image size error");
        //        return View();
        //    }
        //    if (!slide.Photo.CheckFileType("image/"))
        //    {
        //        ModelState.AddModelError("Photo", "Type error exist");
        //        return View();
        //    }



        //    if (System.IO.File.Exists(path))
        //    {
        //        System.IO.File.Delete(path);
        //    }
        //    slide.Image = await slide.Photo.SaveFileAsync(_env.WebRootPath, "img", "slider");
        //var path = Helper.GetPath(_env.WebRootPath, "img", "slider", DBSlide.Image);
        //DBSlide.Image = slide.Image;



    }
}
