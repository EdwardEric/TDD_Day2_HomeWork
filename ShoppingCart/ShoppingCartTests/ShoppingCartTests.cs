using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void CalculateSumPriceTest_買一本哈利波特1_計算出總共100元()
        {
            //arrange
            ShoppingCart shoppingCart = new ShoppingCart();
            List<Book> books = new List<Book>()
            {
                new Book() { Name = "哈利波特1", Price = 100, Count = 1 }
            };

            //act
            var actual = shoppingCart.CalculateSumPrice(books);
            var expected = 100;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateSumPriceTest_第一集買了一本_第二集也買了一本_價格應為190()
        {
            //arrange
            ShoppingCart shoppingCart = new ShoppingCart();
            List<Book> books = new List<Book>()
            {
                new Book() { Name = "哈利波特1", Price = 100, Count = 1 },
                new Book() { Name = "哈利波特2", Price = 100, Count = 1 }
            };

            //act
            var actual = shoppingCart.CalculateSumPrice(books);
            var expected = 190;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateSumPriceTest_一二三集各買了一本_價格應為270()
        {
            //arrange
            ShoppingCart shoppingCart = new ShoppingCart();
            List<Book> books = new List<Book>()
            {
                new Book() { Name = "哈利波特1", Price = 100, Count = 1 },
                new Book() { Name = "哈利波特2", Price = 100, Count = 1 },
                new Book() { Name = "哈利波特3", Price = 100, Count = 1 }
            };

            //act
            var actual = shoppingCart.CalculateSumPrice(books);
            var expected = 270;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateSumPriceTest_一二三四集各買了一本_價格應為320()
        {
            //arrange
            ShoppingCart shoppingCart = new ShoppingCart();
            List<Book> books = new List<Book>()
            {
                new Book() { Name = "哈利波特1", Price = 100, Count = 1 },
                new Book() { Name = "哈利波特2", Price = 100, Count = 1 },
                new Book() { Name = "哈利波特3", Price = 100, Count = 1 },
                new Book() { Name = "哈利波特4", Price = 100, Count = 1 }
            };

            //act
            var actual = shoppingCart.CalculateSumPrice(books);
            var expected = 320;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}