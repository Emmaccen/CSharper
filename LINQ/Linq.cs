using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp.LINQ
{
    class Linq
    {
        public static void Run()
        {
            List<Book> books = new List<Book>()
            {
                new Book {Id = 1,Title = "First Book", Price = 4.99f},
                new Book {Id = 2,Title = "Second Book", Price = 55.99f},
                new Book {Id = 3,Title = "Third Book", Price = 199.99f},
                new Book {Id = 4,Title = "Fourth Book", Price = 3.99f},
                new Book {Id = 5,Title = "Fifth Book", Price = 24.99f},
                new Book {Id = 6,Title = "Sixth Book", Price = 10.99f},
            };

            var cheapBooks = books
                .Where(book => book.Price > 10)
                .OrderBy(book => book.Price)
                .Select(book => book.Title);


            foreach (var book in cheapBooks)
            {
               // Console.WriteLine(book);
            }
            var bookId3 = books
                .SingleOrDefault(book => book.Id == 3);
            //Console.WriteLine("Book With ID 3 : " + bookId3.Title);

            var getFirstMatch = books
                .FirstOrDefault(book => book.Title == "First Book");
            Console.WriteLine(getFirstMatch.Title);

            // For pagination
            var pageBooks = books.Skip(3).Take(3);
            foreach (var book in pageBooks)
            {
                //Console.WriteLine(book.Title);
            }

            //others
            //.Max(), .Min(), .count(), Sum() etc
        }


    }
    class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public int Id { get; set; }
    }
}
