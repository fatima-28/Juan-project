using Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApp.ViewModels
{
    public class HomeViewModel
    {
      
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Slide> Slides { get; set; }
        public List<Future> Futures { get; set; }


    }
}