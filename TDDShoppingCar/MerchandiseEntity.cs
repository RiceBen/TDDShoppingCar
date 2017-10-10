using System;
namespace TDDShoppingCar
{
    /// <summary>
    /// 購物車商品結構
    /// </summary>
    public class MerchandiseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:TDDShoppingCar.MerchandiseEntity"/> class.
        /// </summary>
        public MerchandiseEntity()
        {
            
        }

        /// <summary>
        /// 商品名稱
        /// </summary>
        /// <value>商品名稱</value>
        public string Title { get; set; }

        /// <summary>
        /// 售價
        /// </summary>
        /// <value>售價</value>
        public decimal Price { get; set; }

        /// <summary>
        /// 數量
        /// </summary>
        /// <value>數量</value>
        public int Quantity { get; set; }
    }
}
