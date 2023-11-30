using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_12
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public Book(string name, string author, string publisher)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
        }
        public delegate int BookComparison(Book book1, Book book2);

    }
}
