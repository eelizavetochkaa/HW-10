using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_12
{

    internal class Program
    {
        static int CompareByTitle(Book book1, Book book2)
        {
            return string.Compare(book1.Name, book2.Name);
        }

        static int CompareByAuthor(Book book1, Book book2)
        {
            return string.Compare(book1.Author, book2.Author);
        }

        static int CompareByPublisher(Book book1, Book book2)
        {
            return string.Compare(book1.Publisher, book2.Publisher);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 12.2");
            Console.WriteLine("Домашенее задание 12.1");
            Complex x = new Complex(8, 3);
            Complex y = new Complex(3, 1);

            Complex summ = x + y;
            Complex diff = x - y;
            Complex comp = x * y;

            Console.WriteLine($"Сумма = {summ}");
            Console.WriteLine($"Разность = {diff}");
            Console.WriteLine($"Произведение = {comp}");

            if (y == x)
            {
                Console.WriteLine("x = y");
            }
            else
            {
                Console.WriteLine("x не равно у");
            }

            Console.WriteLine("Домашнее задание 12.2");
            // Создание массива книг
            Book[] books = new Book[]
            {
            new Book("Маугли", "Редьярд Киплинг", "Литрес"),
            new Book("Программирование на C#", "Тумаков Д.Н.", "КФУ"),
            new Book("Мы", "Замятин Евгений", "Эксмо")
            };

            Container container = new Container(books);

            Comparison<Book> comparison = new Comparison<Book>(CompareByTitle);

            container.SortBooks(comparison);

            container.PrintBooks();
            Console.ReadKey();

        }
    }
}
