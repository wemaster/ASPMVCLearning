using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class PerModel
    {
        public OnlineShopDbContext context = new OnlineShopDbContext();
        public List<TblPer> ListAll()
        {
            var list = context.Database.SqlQuery<TblPer>("").ToList();
            return list;
        }
    }
}