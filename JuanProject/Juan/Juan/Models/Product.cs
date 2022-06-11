using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string  Name { get; set; }
        public double Price { get; set; }
       
        public int Count { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProductCategory> Categories { get; set; }

    }
}
