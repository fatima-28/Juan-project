﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Slide
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string ISummary { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }

    }
}
