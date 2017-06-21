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
            var actual = target.Checkout(new List<Product>()
                {
                    new Product() { Id = "HP-1", Name = "哈利波特1", Price = 100 }
                }
            );

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
            var actual = target.Checkout(new List<Product>()
                {
                    new Product() { Id = "HP-1", Name = "哈利波特1", Price = 100 },
                    new Product() { Id = "HP-2", Name = "哈利波特2", Price = 100 },
                }
            );

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}