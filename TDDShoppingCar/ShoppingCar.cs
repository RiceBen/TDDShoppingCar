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
        public decimal Calculate(int qty)
        {
            return 100m * qty;
        }

        /// <summary>
        /// 計算購物車內金額
        /// </summary>
        /// <returns>應付金額</returns>
        /// <param name="entity">購物車結構</param>
        public decimal Calculate(ShoppingCarEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
