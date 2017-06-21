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
        private decimal _discount { get; set; }
        private IDictionary<string, Book> _bookDictionary { get; set; }

        public ShoppingCart()
        {
            _books = new List<Book>();
            _discount = 1;
        }


        public void Add(Book book, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                _books.Add(book);
            }
        }

        public ShoppingCart GetDiscount()
        {
            _bookDictionary = _books.ToDictionary(x => x.Name, x => x);
            var episodeCount = _bookDictionary.Where(x => x.Key.Contains("哈利波特")).Count();
            if (episodeCount >= 3)
            {
                _discount = 0.9m;
            }
            else if (episodeCount == 2)
            {
                _discount = 0.95m;
            }
            return this;
        }

        public decimal Checkout() {
            return _books.Sum(x => x.Price) * _discount;
        }
    }

    public class Book
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
