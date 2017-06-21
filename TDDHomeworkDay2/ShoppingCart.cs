using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDHomeworkDay2
{
    public class ShoppingCart
    {
        private List<Book> _books { get; set; }
        private IDictionary<string, Book> _bookDictionary { get; set; }

        public ShoppingCart()
        {
            _books = new List<Book>();
        }


        public void Add(Book book, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                _books.Add(book);
            }
        }

        public decimal GetDiscount()
        {
            decimal discount = 1;

            _bookDictionary = _books.ToDictionary(x => x.Name, x => x);

            var episodeCount = _bookDictionary.Where(x => x.Key.Contains("哈利波特")).Count();
            if (episodeCount >= 5)
            {
                discount = 0.75m;
            }
            else if (episodeCount >= 4)
            {
                discount = 0.8m;
            }
            else if (episodeCount == 3)
            {
                discount = 0.9m;
            }
            else if (episodeCount == 2)
            {
                discount = 0.95m;
            }
            return discount;
        }

        public decimal Checkout() {
            var discount = GetDiscount();

            return _books.Sum(x => x.Price) * discount;
        }
    }

    public class Book
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
