﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.ViewModels.BlogViewModels
{
    public class BlogCreateVM
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public IFormFile Photo { get; set; }
        public DateTime Date { get; set; }
    }
}
