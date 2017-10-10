using System;
using TDDShoppingCar.Test.Data;
using Xunit;

namespace TDDShoppingCar.Test
{
    public class ShoppingCarTest
    {
        [Fact]
        public void Buy1BookSpend100()
        {
            //// arrange
            var shoppingCar = new ShoppingCar();
            var expect = 100m;
            var qty = 1;

            //// act
            var actual = shoppingCar.Calculate(qty);

            //// asssert
            Assert.Equal(expect, actual);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetDifferentBooksMerchandise), MemberType = typeof(TestDataGenerator))]
        public void BuyDifferentBookGetDiscount(ShoppingCarEntity item)
        {
            //// arrange
            var shoppingCar = new ShoppingCar();
            var expect = 0m;
            var merchandiseCount = item.MerchandiseList.Count;
            if (merchandiseCount == 2)
            {
                expect = 190m;
            }
            else if (merchandiseCount == 3)
            {
                expect = 270m;
            }else if(merchandiseCount == 4)
            {
                expect = 320m;
            }
            else
            {
                expect = 375m;
            }

            //// act
            var actual = shoppingCar.Calculate(item);

            //// assert
            Assert.Equal(expect, actual);
        }
    }
}
