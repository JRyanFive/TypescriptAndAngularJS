using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Daily.Models;

namespace Daily.Web.Models
{
    public class CategoryViewModel
    {
        public List<News> LeftNewsList { get; set; }

        public List<News> RightNewsList { get; set; }

        public List<News> FocusNewsList { get; set; }

        public List<News> InterestingNewsList { get; set; }
    }
}