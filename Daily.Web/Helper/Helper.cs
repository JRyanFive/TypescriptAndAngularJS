using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Daily.Web.Models;
using Enum = Daily.Models.Enum;

namespace Daily.Web.Helper
{
    public class Helper
    {
        public static CategoryLinkViewModel CategoryLink(Enum.eCategoryType type)
        {
            var cate = new CategoryLinkViewModel();
            switch (type)
            {
                case Enum.eCategoryType.SOCIETY:
                    cate.CategoryTitle = "Tin tức thời sự, chính trị, xã hội từ các nguồn báo | DailyTinTuc.com";
                    cate.CategoryName = "Xã hội";
                    cate.CategoryLink = "xa-hoi";
                    break;
                case Enum.eCategoryType.POLITIC:
                    cate.CategoryTitle = "Tin nhanh thời sự, chính trị, xã hội, đời sống Việt Nam 24h trong ngày - Chính trị";
                    cate.CategoryName = "Chính trị";
                    cate.CategoryLink = "chinh-tri";
                    break;
                case Enum.eCategoryType.TRAFFIC:
                    cate.CategoryTitle = "Tin nhanh thời sự, chính trị, xã hội, đời sống Việt Nam 24h trong ngày - Chính trị";
                    cate.CategoryName = "Giao thông";
                    cate.CategoryLink = "giao-thong";
                    break;
                case Enum.eCategoryType.ENVIROMENT:
                    cate.CategoryTitle = "Tin nhanh thời sự, chính trị, xã hội, đời sống Việt Nam 24h trong ngày - Chính trị";
                    cate.CategoryName = "Môi trường";
                    cate.CategoryLink = "moi-truong";
                    break;
                case Enum.eCategoryType.WORLD:
                    cate.CategoryTitle = "Tin tức, sự kiện thế giới nổi bật trong ngày, trong tuần";
                    cate.CategoryName = "Thế giới";
                    cate.CategoryLink = "the-gioi";
                    break;
                case Enum.eCategoryType.LAW:
                    cate.CategoryTitle = "Tin tức Pháp luật được cập nhật: 24h, vnexpress, dantri, vietnamnet, kenh14, soha | DailyTinTuc — Kênh tin tức tổng hợp cập nhật 24h/7 từ dantri, vietnamnet, vnexpress";
                    cate.CategoryName = "Pháp luật";
                    cate.CategoryLink = "phap-luat";
                    break;
                case Enum.eCategoryType.EDUCATION:
                    cate.CategoryTitle = "Tin tức Giáo dục được cập nhật: 24h, vnexpress, dantri, vietnamnet, kenh14, soha | DailyTinTuc — Đọc báo mới mỗi ngày";
                    cate.CategoryName = "Giáo dục";
                    cate.CategoryLink = "giao-duc";
                    break;
                case Enum.eCategoryType.ENTERTAIMENT:
                    cate.CategoryTitle = "Trang thông tin thời trang, giải trí và giới showbiz, ngôi sao";
                    cate.CategoryName = "Giải trí";
                    cate.CategoryLink = "giai-tri";
                    break;
                case Enum.eCategoryType.BUSINESS:
                    cate.CategoryTitle = "Tin nhanh kinh tế, tài chính, doanh nghiệp, thị trường 24h - DailyTinTuc.com";
                    cate.CategoryName = "Kinh doanh";
                    cate.CategoryLink = "kinh-doanh";
                    break;
                case Enum.eCategoryType.SPORT:
                    cate.CategoryTitle = "Thông tin thể thao, bóng đá cập nhật liên tục";
                    cate.CategoryName = "Thể thao";
                    cate.CategoryLink = "the-thao";
                    break;
                case Enum.eCategoryType.FOOTBALL:
                    cate.CategoryTitle = "Thông tin thể thao, bóng đá cập nhật liên tục - Bóng đá";
                    cate.CategoryName = "Bóng đá";
                    cate.CategoryLink = "bong-da";
                    break;
                case Enum.eCategoryType.TENIS:
                    cate.CategoryTitle = "Thông tin thể thao, bóng đá cập nhật liên tục - Tenis";
                    cate.CategoryName = "Quần vợt";
                    cate.CategoryLink = "quan-vot";
                    break;
                case Enum.eCategoryType.SPORT_OTHER:
                    cate.CategoryTitle = "Hậu trường thể thao, bóng đá - DailyTinTuc.com";
                    cate.CategoryName = "Hậu trường";
                    cate.CategoryLink = "hau-truong-the-thao";
                    break;
                case Enum.eCategoryType.TRAVEL:
                    cate.CategoryTitle = "Thông tin du lịch, địa điểm dã ngoại, tour VN thế giới giá rẻ";
                    cate.CategoryName = "Du lịch";
                    cate.CategoryLink = "du-lich";
                    break;
                case Enum.eCategoryType.TECHNOLOGY:
                    cate.CategoryTitle = "Tin tức, giá cả, đánh giá, thủ thuật, hướng dẫn sản phẩm công nghệ, di động | DailyTinTuc";
                    cate.CategoryName = "Công nghệ";
                    cate.CategoryLink = "khoa-hoc-cong-nghe";
                    break;
                case Enum.eCategoryType.LIFE:
                    cate.CategoryTitle = "Tình yêu và kiến thức giới tính dành cho mọi lứa tuổi";
                    cate.CategoryName = "Đời sống";
                    cate.CategoryLink = "doi-song";
                    break;
                case Enum.eCategoryType.LOVE:
                    cate.CategoryTitle = "Tình yêu và kiến thức giới tính dành cho mọi lứa tuổi";
                    cate.CategoryName = "Tình yêu - Hôn nhân";
                    cate.CategoryLink = "tinh-yeu-hon-nhan";
                    break;
                case Enum.eCategoryType.HEALTH:
                    cate.CategoryTitle = "Trang tin sức khoẻ và tư vấn sức khoẻ";
                    cate.CategoryName = "Sức khỏe - Y tế";
                    cate.CategoryLink = "suc-khoe-y-te";
                    break;
                case Enum.eCategoryType.BEAUTY:
                    cate.CategoryTitle = "Tư vấn làm Đẹp - Thời trang từ: baomoi, ngoisao.net, kênh 14, eva, afamily, zingnews, megafun | DailyTinTuc — Kênh tin tức tổng hợp cập nhật 24h/7 từ dantri, vietnamnet, vnexpress";
                    cate.CategoryName = "Đẹp";
                    cate.CategoryLink = "phu-nu-dep";
                    break;
                case Enum.eCategoryType.MAKE_BEAUTY:
                    cate.CategoryTitle = "Tư vấn làm Đẹp - Thời trang từ: baomoi, ngoisao.net, kênh 14, eva, afamily, zingnews, megafun | DailyTinTuc — Báo mới mỗi ngày";
                    cate.CategoryName = "Làm đẹp";
                    cate.CategoryLink = "lam-dep";
                    break;
                case Enum.eCategoryType.FASHION:
                    cate.CategoryTitle = "Xu hướng Thời trang trẻ Đẹp Mới Nhất";
                    cate.CategoryName = "Thời trang";
                    cate.CategoryLink = "thoi-trang";
                    break;
                case Enum.eCategoryType.VEHICLE:
                    cate.CategoryTitle = "Trang thông tin về xe, phương tiện đi lại và đánh giá xe";
                    cate.CategoryName = "Ôtô - Xe máy";
                    cate.CategoryLink = "o-to-xe-may";
                    break;


            }
            return cate;
        }

        public static List<CategoryLinkViewModel> GetLinkTree(Enum.eCategoryType type)
        {
            var cate = new List<CategoryLinkViewModel>();
            switch (type)
            {
                case Enum.eCategoryType.POLITIC:
                    cate.Add(CategoryLink(Enum.eCategoryType.SOCIETY));
                    break;
                case Enum.eCategoryType.TRAFFIC:
                    cate.Add(CategoryLink(Enum.eCategoryType.SOCIETY));
                    break;
                case Enum.eCategoryType.ENVIROMENT:
                    cate.Add(CategoryLink(Enum.eCategoryType.SOCIETY));
                    break;
               
                case Enum.eCategoryType.FOOTBALL:
                    cate.Add(CategoryLink(Enum.eCategoryType.SPORT));
                    break;
                case Enum.eCategoryType.TENIS:
                    cate.Add(CategoryLink(Enum.eCategoryType.SPORT));
                    break;
                case Enum.eCategoryType.SPORT_OTHER:
                    cate.Add(CategoryLink(Enum.eCategoryType.SPORT));
                    break;
              
                case Enum.eCategoryType.LOVE:
                    cate.Add(CategoryLink(Enum.eCategoryType.LIFE));
                    break;
                case Enum.eCategoryType.HEALTH:
                    cate.Add(CategoryLink(Enum.eCategoryType.LIFE));
                    break;
          
                case Enum.eCategoryType.MAKE_BEAUTY:
                    cate.Add(CategoryLink(Enum.eCategoryType.BEAUTY));
                    break;
                case Enum.eCategoryType.FASHION:
                    cate.Add(CategoryLink(Enum.eCategoryType.BEAUTY));
                    break;
            }

            cate.Add(CategoryLink(type));
            return cate;
        }
    }
}