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
                    new Product{Name = "yty",Price = 45},
                    new Product{Name = "livir",Price = 45},
                    new Product{Name = "owen",Price = 45},
                    new Product{Name = "van",Price = 45},
                }
            };
            //ShoppingCart用扩展的TotalPrices方法,得到了总价格
            decimal totalPrices = cart.TotalPrices();

            //返回View视图
            return View("Suprise", (object)$"Total:{totalPrices:C}");
        }

        public ViewResult UseExtensionEnumerable()
        {
            IEnumerable<Product> products = new ShoppingCart()
            {
                //Products是ShoppingCart中的List属性
                Products = new List<Product>()
                {
                    new Product{Name = "yty",Price = 250},
                    new Product{Name = "livir",Price = 250},
                    new Product{Name = "van owen",Price = 250},
                    new Product{Name = "Micheal Jackson",Price = 250},
                }
            };

            #region 也可以添加数组

            Product[] productArray =
            {
                new Product {Name = "ab", Price = 150},
                new Product {Name = "cd", Price = 150},
                new Product {Name = "ef", Price = 150},
                new Product {Name = "gh", Price = 150},
            };

            #endregion

            decimal totalPrices = products.TotalPrices();

            return View("PriceResult", (object)$"CartTotal Number:{totalPrices}");
        }
    }
}