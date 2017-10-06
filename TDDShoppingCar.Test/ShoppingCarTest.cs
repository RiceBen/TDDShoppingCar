using System;
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
            var actual = shoppingCar.Caculate(qty);

            //// asssert
            Assert.Equal(expect, actual);
        }
    }
}
