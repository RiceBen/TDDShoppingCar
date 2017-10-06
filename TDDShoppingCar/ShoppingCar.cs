using System;

namespace TDDShoppingCar
{
    /// <summary>
    /// 購物車
    /// </summary>
    public class ShoppingCar
    {
        /// <summary>
        /// 計算購物車內金額
        /// </summary>
        /// <returns>應付金額</returns>
        /// <param name="qty">數量</param>
        public decimal Caculate(int qty)
        {
            return 100m * qty;
        }
    }
}
