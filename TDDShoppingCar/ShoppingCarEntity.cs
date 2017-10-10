using System;
using System.Collections.Generic;

namespace TDDShoppingCar
{
    public class ShoppingCarEntity
    {
        public ShoppingCarEntity()
        {
            this.MerchandiseList = new List<MerchandiseEntity>();
        }

        public List<MerchandiseEntity> MerchandiseList { get; set; }

        /// <summary>
        /// 會員等級（Normal, VIP）
        /// </summary>
        /// <value>會員等級</value>
        public string MemberLevel { get; set; }
    }
}
