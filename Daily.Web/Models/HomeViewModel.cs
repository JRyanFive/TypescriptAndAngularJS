using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Daily.Models;

namespace Daily.Web.Models
{
    public class HomeViewModel
    {
        //Phap luật
        public List<News> LawNewsList { get; set; }
        public News LawNewsFirst { get; set; }

        //The gioi
        public List<News> WorldNewsList { get; set; }
        public News WorldNewsFirst { get; set; }

        //Xa hoi
        public List<News> SocietyNewsList { get; set; }
        public News SocietyNewsFirst { get; set; }

        //The thao
        public List<News> SportNewsList { get; set; }
        public News SportNewsFirst { get; set; }

        //Giai tri
        public List<News> EntertaimentNewsList { get; set; }

        //Doi song
        public List<News> LifeNewsList { get; set; }

        public News HotNewsToday { get; set; }
        public List<News> HotNewsTodayList { get; set; }

        public List<News> TopLeftNewsList { get; set; }

        public List<News> TopRightNewsList { get; set; }
    }
}