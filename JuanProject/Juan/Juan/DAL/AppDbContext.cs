using Juan.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            

    }
        public DbSet<Product> Products { get; set; }
        public DbSet< Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Future> Futures { get; set; }
        public DbSet<NewProduct> NewProducts { get; set; }
        public DbSet<OurBlog> OurBlogs { get; set; }




    }
}