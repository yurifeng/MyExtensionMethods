using System.Collections.Generic;

namespace WebApplication9.Models
{
    /// <summary>
    /// 假设的无法修改的ShoppingCart类
    /// 假设这个类中,没有我们需要的求所有Products总价格的方法
    /// 可以创建一个类来扩展该ShoppingCart类
    /// </summary>
    public class ShoppingCart
    {
        /// <summary>
        /// 将存有Products的List集合作为其自动属性
        /// </summary>
        public List<Product> Products { get; set; }
    }
}