using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Daily.Models;

namespace Daily.Web.Models
{
    public class NewsViewModel
    {
        public List<CategoryLinkViewModel> LinkTree { get; set; }

        public News ViewNews { get; set; }
        
        public List<News> FocusNewsList { get; set; }

        public List<News> HotNewsList { get; set; }
    }
}