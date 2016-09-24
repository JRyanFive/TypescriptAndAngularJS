using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Daily.DataAccess.Repositories;
using Daily.Web.Models;
using Enum = Daily.Models.Enum;

namespace Daily.Web.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public async Task<ActionResult> ReadNews(string parram)
        {
            var newsRepository = new NewsRepository();
            var newsViewModel = new NewsViewModel();
          
            var str = parram.Split('-');
            
            newsViewModel.ViewNews = await newsRepository.SelectById(str.Last());

            ViewBag.Title = newsViewModel.ViewNews.Title;

            newsViewModel.FocusNewsList = await newsRepository.SelectNewsList(4, 11);
            newsViewModel.HotNewsList = await newsRepository.SelectNewsList(1, 8);

            newsViewModel.LinkTree= Helper.Helper.GetLinkTree(newsViewModel.ViewNews.CategoryType);

            return View(newsViewModel);
        }

        public async Task<ActionResult> Category(Enum.eCategoryType type, int? page)
        {
            ViewBag.CategoryLink = Helper.Helper.CategoryLink(type);
            ViewBag.Title = ViewBag.CategoryLink.CategoryTitle;

            var newsRepository = new NewsRepository();
            var categoryViewModel = new CategoryViewModel();
            categoryViewModel.LeftNewsList = await newsRepository.SelectNewsList(4, 8);
            categoryViewModel.RightNewsList = await newsRepository.SelectNewsList(1, 8);

            categoryViewModel.FocusNewsList = await newsRepository.SelectNewsList(4, 11);
            categoryViewModel.InterestingNewsList = await newsRepository.SelectNewsList(6, 13);

            return View(categoryViewModel);
        }

        public async Task<ActionResult> Search(string search, int? page)
        {
            //ViewBag.CategoryLink = Helper.Helper.CategoryLink(type);
            //ViewBag.Title = ViewBag.CategoryLink.CategoryTitle;

            //var newsRepository = new NewsRepository();
            //var categoryViewModel = new CategoryViewModel();
            //categoryViewModel.LeftNewsList = await newsRepository.SelectNewsList(4, 8);
            //categoryViewModel.RightNewsList = await newsRepository.SelectNewsList(1, 8);

            //categoryViewModel.FocusNewsList = await newsRepository.SelectNewsList(4, 11);
            //categoryViewModel.InterestingNewsList = await newsRepository.SelectNewsList(6, 13);

            return View();
        }
    }
}