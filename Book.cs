using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask_8_homework_bookstore_application
{
    internal class Book
    {
        public Book(string title, double price)
        {
            Title = title;
            Price = price;
        }

        public string Title { get; }
        public double Price { get; }
    }
}
