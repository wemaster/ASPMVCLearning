using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class BannerModel
    {
        public OnlineShopDbContext context = new OnlineShopDbContext();
        public List<TblBanner> ListAll()
        {
            var list = context.TblBanners.Where(x => x.Status == true).OrderBy(y => y.IDbanner).ToList();
            return list;
        }
    }
}