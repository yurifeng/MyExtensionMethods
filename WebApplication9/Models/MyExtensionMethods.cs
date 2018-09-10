namespace WebApplication9.Models
{
    public static class MyExtensionMethods
    {
        /// <summary>
        /// 该类就是扩展ShoppingCart类的类
        /// </summary>
        /// <param name="cartParam"></param>
        /// <returns>得到Products的总价格</returns>
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;

            foreach (Product product in cartParam.Products)
            {
                total += product.Price;
            }

            return total;
        }
    }
}