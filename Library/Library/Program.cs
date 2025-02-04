﻿using System;
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
                Console.WriteLine("Title: " + books[i].title + ", Author: " + books[i].author);
            }
        }

        public void FindBook(string t)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == t)
                {
                    Console.WriteLine("Found: " + books[i].title + " by " + books[i].author);
                    return;
                }
            }
            Console.WriteLine("Book not found");
        }
    }

    class Book
    {
        public string title;
        public string author;

        public Book(string t, string a)
        {
            title = t;
            author = a;
        }
    }
}
