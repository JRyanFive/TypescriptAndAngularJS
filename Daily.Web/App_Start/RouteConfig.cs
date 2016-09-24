using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Enum = Daily.Models.Enum;

namespace Daily.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
              "XaHoi",
              "xa-hoi",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.SOCIETY,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "ChinhTri",
              "chinh-tri",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.POLITIC,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "GiaoThong",
              "giao-thong",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.TRAFFIC,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "MoiTruong",
              "moi-truong",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.ENVIROMENT,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "TheGioi",
              "the-gioi",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.WORLD,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "PhapLuat",
              "phap-luat",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.LAW,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "GiaoDuc",
              "giao-duc",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.EDUCATION,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "GiaiTri",
              "giai-tri",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.ENTERTAIMENT,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "KinhDoanh",
              "kinh-doanh",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.BUSINESS,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "TheThao",
              "the-thao",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.SPORT,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "BongDa",
              "bong-da",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.FOOTBALL,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "QuanVot",
              "quan-vot",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.TENIS,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "HauTruongTheThao",
              "hau-truong-the-thao",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.SPORT_OTHER,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "DuLich",
              "du-lich",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.TRAVEL,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "CongNghe",
              "khoa-hoc-cong-nghe",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.TECHNOLOGY,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "DoiSong",
              "doi-song",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.LIFE,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "TinhYeuHonNhan",
              "tinh-yeu-hon-nhan",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.LOVE,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "SucKhoeYTe",
              "suc-khoe-y-te",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.HEALTH,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "PhuNuDep",
              "phu-nu-dep",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.BEAUTY,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "LamDep",
              "lam-dep",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.MAKE_BEAUTY,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "ThoiTrang",
              "thoi-trang",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.FASHION,
                  page = UrlParameter.Optional
              });
            routes.MapRoute(
              "OtoXeMay",
              "o-to-xe-may",
              new
              {
                  controller = "News",
                  action = "Category",
                  type = Enum.eCategoryType.VEHICLE,
                  page = UrlParameter.Optional
              });
           
            routes.MapRoute(
               "ReadNews",
               "{parram}",
               new { controller = "News", action = "ReadNews", News = UrlParameter.Optional }
               );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

           
        }
    }
}
