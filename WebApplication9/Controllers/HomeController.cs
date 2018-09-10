using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult UseExtension()
        {
            //创建ShoppingCart实例
            ShoppingCart cart = new ShoppingCart()
            {
                Products = new List<Product>()
                {
                    new Product(){Name = "yty",Price = 45},
                    new Product(){Name = "livir",Price = 45},
                    new Product(){Name = "owen",Price = 45},
                    new Product(){Name = "van",Price = 45},
                }
            };
            //ShoppingCart用扩展的TotalPrices方法,得到了总价格
            decimal totalPrices = cart.TotalPrices();

            //返回View视图
            return View("Suprise", (object)string.Format("Total:{0:C}", totalPrices));
        }
    }
}