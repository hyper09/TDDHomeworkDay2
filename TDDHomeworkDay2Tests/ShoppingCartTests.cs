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
        
        [TestMethod]
        public void Buy_one_episode1_and_one_episode2_price_should_be_190()
        {
            //arrange
            var target = new ShoppingCart();
            var expected = 190;

            //act
            target.Add(new Book() { Name = "哈利波特1", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特2", Price = 100 }, 1);
            var actual = target.Checkout();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_one_episode1_and_one_episode2_and_one_episode3_price_should_be_270()
        {
            //arrange
            var target = new ShoppingCart();
            var expected = 270;

            //act
            target.Add(new Book() { Name = "哈利波特1", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特2", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特3", Price = 100 }, 1);
            var actual = target.Checkout();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_one_episode1_and_one_episode2_and_one_episode3_and_one_episode4_price_should_be_320()
        {
            //arrange
            var target = new ShoppingCart();
            var expected = 320;

            //act
            target.Add(new Book() { Name = "哈利波特1", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特2", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特3", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特4", Price = 100 }, 1);
            var actual = target.Checkout();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_one_episode1_and_one_episode2_and_one_episode3_and_one_episode4_and_one_episode5_price_should_be_375()
        {
            //arrange
            var target = new ShoppingCart();
            var expected = 375;

            //act
            target.Add(new Book() { Name = "哈利波特1", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特2", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特3", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特4", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特5", Price = 100 }, 1);
            var actual = target.Checkout();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_one_episode1_and_one_episode2_and_two_episode3_price_should_be_370()
        {
            //arrange
            var target = new ShoppingCart();
            var expected = 370;

            //act
            target.Add(new Book() { Name = "哈利波特1", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特2", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特3", Price = 100 }, 2);
            var actual = target.Checkout();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_one_episode1_and_two_episode2_and_two_episode3_price_should_be_460()
        {
            //arrange
            var target = new ShoppingCart();
            var expected = 460;

            //act
            target.Add(new Book() { Name = "哈利波特1", Price = 100 }, 1);
            target.Add(new Book() { Name = "哈利波特2", Price = 100 }, 2);
            target.Add(new Book() { Name = "哈利波特3", Price = 100 }, 2);
            var actual = target.Checkout();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}