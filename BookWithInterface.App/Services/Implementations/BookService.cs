
using BookWithInterface.App.Services.Interfaces;
using BookWithInterface.Core.Models.MinorModels;
using System.Diagnostics;

namespace BookWithInterface.App.Services.Implementations
{
    internal class BookService : IBookService
    {
        private Book[] Books = new Book[0];

        public string Title { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }
        public string CreatedDate { get; set; }

        public void Create()
        {
            Book NewBook = new Book();

            NewBook.CreatedDate = DateTime.UtcNow.AddHours(4);

            Console.WriteLine("Please, add Title");

            NewBook.Title = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(NewBook.Title))
            {
                Console.WriteLine("Please, add valid Title");

                NewBook.Title = Console.ReadLine();
            }

            Console.WriteLine("Please, add Author");

            NewBook.Author = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(NewBook.Author))
            {
                Console.WriteLine("Please, add valid Author");

                NewBook.Author = Console.ReadLine();
            }

            Console.WriteLine("Please, add Price");

            string numberstring = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(numberstring))
            {
                Console.WriteLine("Please, add valid Price");

                numberstring = Console.ReadLine();
            }

            NewBook.Price = double.Parse(numberstring);

            Array.Resize(ref Books, Books.Length + 1);

            Books[Books.Length - 1] = NewBook;
        }

      
        public void ShowAll()
        {
            if (Books.Length == 0)
            {
                Console.WriteLine("No Books added");
            }

            foreach (var book in Books)
            {
                Console.WriteLine($"Title: {book.Title} Author: {book.Author} Price: {book.Price} CreatedDate: {book.CreatedDate}");
            }
        }
    }
}      


    

