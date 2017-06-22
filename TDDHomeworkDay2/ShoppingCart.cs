using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDHomeworkDay2
{
    public class ShoppingCart
    {
        private IList<Book> _books { get; set; }
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

        //很髒很醜，目前沒想到更好的做法
        public decimal Checkout()
        {
            _bookDictionary = _books.GroupBy(x => x.Name).ToDictionary(x => x.Key, x => x.FirstOrDefault());

            decimal total = 0;

            while (_books.Count > 0)
            {
                decimal subTotal = 0;
                int episodeCount = 0;

                foreach (var bookName in _bookDictionary.Keys)
                {
                    for (int i = _books.Count - 1; i >= 0; i--)
                    {
                        if (_books[i].Name == bookName)
                        {
                            subTotal += _books[i].Price;
                            episodeCount++;
                            _books.RemoveAt(i);
                            break;
                        }
                    }
                }

                total += subTotal * GetDiscount(episodeCount);
            }

            return total;
        }

        private decimal GetDiscount(int episodeCount)
        {
            decimal discount = default(decimal);

            switch (episodeCount)
            {
                case 0:
                case 1:
                    discount = 1;
                    break;
                case 2:
                    discount = 0.95m;
                    break;
                case 3:
                    discount = 0.9m;
                    break;
                case 4:
                    discount = 0.8m;
                    break;
                case 5:
                default:
                    discount = 0.75m;
                    break;
            }

            return discount;
        }

    }

    public class Book
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
