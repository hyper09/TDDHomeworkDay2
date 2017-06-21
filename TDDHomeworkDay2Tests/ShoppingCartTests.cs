using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TDDHomeworkDay2.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void Buy_one_episode1_price_should_be_100()
        {
            //arrange
            var target = new ShoppingCart();
            var expected = 100;

            //act
            target.Add(new Book() { Name = "哈利波特1", Price = 100 }, 1);
            var actual = target.Checkout();

            //assert
            Assert.AreEqual(expected, actual);
        }

        //第一集買了一本，第二集也買了一本，價格應為100*2*0.95=190
        [TestMethod]
        public void Buy_one_episode1_and_one_episode2_price_should_be_190()
        {
            //arrange
            var target = new ShoppingCart();
            var expected = 190;

            //act
            target.Add(new Book() { Name = "哈利波特1", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特2", Price = 100 }, 1);
            var actual = target.GetDiscount().Checkout();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}