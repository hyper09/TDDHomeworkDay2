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
                    new Product() { Id = "", Name = "哈利波特1", Price = 100 }
                }
            );

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}