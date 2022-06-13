using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class OurBlog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Summary { get; set; }
        public string SharedBy { get; set; }
        public string Date { get; set; }
        public bool IsDeleted { get; set; }

    }
}
