using System;
using System.Collections.Generic;

namespace TDDShoppingCar.Test.Data
{
    public class TestDataGenerator
    {
        /// <summary>
        /// 取得購買不同書籍的情境
        /// </summary>
        /// <returns>購買不同書籍的購物車情境</returns>
        public static IEnumerable<object[]> GetDifferentBooksMerchandise()
        {
            //// 該系列買兩本不同的書，打5折
            yield return new object[]{
                new ShoppingCarEntity{
                    MerchandiseList = {
                        new MerchandiseEntity{ Title = "HarryPotter_1", Price = 100m, Quantity = 1},
                        new MerchandiseEntity{ Title = "HarryPotter_2", Price = 100m, Quantity = 1}
                    },
                    MemberLevel = "Normal"
                }
            };

            //// 該系列買三本部同的書，打10折
            yield return new object[]{
                new ShoppingCarEntity{
                    MerchandiseList = {
                        new MerchandiseEntity{ Title = "HarryPotter_1", Price = 100m, Quantity = 1},
                        new MerchandiseEntity{ Title = "HarryPotter_2", Price = 100m, Quantity = 1},
                        new MerchandiseEntity{ Title = "HarryPotter_3", Price = 100m, Quantity = 1}
                    },
                    MemberLevel = "Normal"
                }
            };

            //// 該系列買四本部同的書，打20折
            yield return new object[]{
                new ShoppingCarEntity{
                    MerchandiseList = {
                        new MerchandiseEntity{ Title = "HarryPotter_1", Price = 100m, Quantity = 1},
                        new MerchandiseEntity{ Title = "HarryPotter_2", Price = 100m, Quantity = 1},
                        new MerchandiseEntity{ Title = "HarryPotter_3", Price = 100m, Quantity = 1},
                        new MerchandiseEntity{ Title = "HarryPotter_4", Price = 100m, Quantity = 1}
                    }, 
                    MemberLevel = "Normal"
                }
            };

            //// 該系列買五本部同的書，打25折
            yield return new object[]{
                new ShoppingCarEntity{
                    MerchandiseList = {
                        new MerchandiseEntity{ Title = "HarryPotter_1", Price = 100m, Quantity = 1},
                        new MerchandiseEntity{ Title = "HarryPotter_2", Price = 100m, Quantity = 1},
                        new MerchandiseEntity{ Title = "HarryPotter_3", Price = 100m, Quantity = 1},
                        new MerchandiseEntity{ Title = "HarryPotter_4", Price = 100m, Quantity = 1},
                        new MerchandiseEntity{ Title = "HarryPotter_5", Price = 100m, Quantity = 1}
                    }, 
                    MemberLevel = "Normal"
                }
            };
        }
    }
}