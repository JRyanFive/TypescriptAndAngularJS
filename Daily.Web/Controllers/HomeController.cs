using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Daily.DataAccess.Repositories;
using Daily.Web.Models;

namespace Daily.Web.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index(string id)
        {
            var homeModel = new HomeViewModel();
            var aaa = new NewsRepository();

            homeModel.LawNewsList = await aaa.SelectNewsList(0, 5);
            homeModel.LawNewsFirst = await aaa.SelectNews(5);

            homeModel.WorldNewsList = await aaa.SelectNewsList(5, 10);
            homeModel.WorldNewsFirst = await aaa.SelectNews(5);

            homeModel.SocietyNewsList = await aaa.SelectNewsList(4, 9);
            homeModel.SocietyNewsFirst = await aaa.SelectNews(5);

            homeModel.SportNewsList = await aaa.SelectNewsList(9, 14);
            homeModel.SportNewsFirst = await aaa.SelectNews(7);

            homeModel.EntertaimentNewsList = await aaa.SelectNewsList(3, 8);

            homeModel.LifeNewsList = await aaa.SelectNewsList(4, 14);


            homeModel.TopLeftNewsList = await aaa.SelectNewsList(3, 4);
            homeModel.TopRightNewsList = await aaa.SelectNewsList(3, 10);

            homeModel.HotNewsToday = await aaa.SelectNews(5);
            homeModel.HotNewsTodayList = await aaa.SelectNewsList(5, 10);

            return View(homeModel);
        }
    }
}