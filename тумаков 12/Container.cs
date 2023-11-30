using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static тумаков_12.Book;

namespace тумаков_12
{
    public class Container
    {
        private Book[] books;

        public Container(Book[] books)
        {
            this.books = books;
        }

        public void SortBooks(Comparison<Book> comparison)
        {
            Array.Sort(books, comparison);
        }

        public void PrintBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Название: {book.Name}, Автор: {book.Author}, Издательство: {book.Publisher}");
            }
        }

    }
}
