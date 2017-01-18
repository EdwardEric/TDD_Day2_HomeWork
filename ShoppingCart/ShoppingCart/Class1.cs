using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
    public class ShoppingCart
    {
        public double CalculateSumPrice(List<Book> bookGroup)
        {
            double result = 0;
            foreach (var book in bookGroup)
                result += book.Price * book.Count;
            return result;
        }
    }
}
