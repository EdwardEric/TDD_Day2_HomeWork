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
            double preferential = 1;
            while(bookGroup.Sum(x =>x.Count) !=0)
            {
                double sum = 0;
                preferential = GetPreferential(bookGroup.Where(x => x.Count > 0).Count());
                foreach (var book in bookGroup)
                {
                    if (book.Count > 0)
                    {
                        sum += book.Price;
                        book.Count -= 1;
                    }       
                }
                result += sum * preferential;

            }
            return result;
        }
        /// <summary>
        /// 取得優惠
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private double GetPreferential(int count)
        {
            double preferential = 1;
            switch (count)
            {
                case 2:
                    preferential = 0.95;
                    break;
                case 3:
                    preferential = 0.90;
                    break;
                case 4:
                    preferential = 0.80;
                    break;
                case 5:
                    preferential = 0.75;
                    break;
            }
            return preferential;
        }
    }
}
