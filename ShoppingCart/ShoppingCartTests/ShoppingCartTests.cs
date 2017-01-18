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
    }
}