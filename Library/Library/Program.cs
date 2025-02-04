using System;
using System.Collections.Generic;

namespace BadCodeLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            lib.AddBook("1984", "George Orwell");
            lib.AddBook("Brave New World", "Aldous Huxley");

            lib.ShowBooks();

            Console.WriteLine("Enter book title to search:");
            string title = Console.ReadLine();
            lib.FindBook(title);
        }
    }

    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(string title, string author)
        {
            books.Add(new Book(title, author));
        }

        public void ShowBooks()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(FormatBook(books[i]));
            }
        }

        public void FindBook(string t)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == t)
                {
                    Console.WriteLine("Found: " + FormatBook(books[i]));
                    return;
                }
            }
            Console.WriteLine("Book not found");
        }

        private string FormatBook(Book book)
        {
            return $"Title: {book.Title}, Author: {book.Author}";
        }
    }

    class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
