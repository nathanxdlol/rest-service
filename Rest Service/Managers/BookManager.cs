using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestService
{
    public class BookManager
    {
        public static List<Book> Data = new List<Book>
        {
            new Book {Title = "xxx",Author = "Kuba",PageNumber = 1,ISBN13 = "0", },
            new Book {Title = "yyy",Author = "Piotr",PageNumber = 2 ,ISBN13 = "1", },
            new Book {Title = "yyy",Author = "Nathan",PageNumber = 3,ISBN13 = "2", },
            new Book {Title = "zzz",Author = "Jakub",PageNumber = 4,ISBN13 = "3", },
        };
        public Book Add(Book newBook)
        {
            Data.Add(newBook);
            return newBook;
        }
        public Book Update(string ISBN13, Book updates)
        {

            book.Title = updates.Title;
            book.PageNumber = updates.PageNumber;
            book.Author = updates.Author;
            Book book = Data.Find(book1 => book1.ISBN13.Contains(ISBN13));
            if (book == null) return null;
            return book;
        }
        public Book Delete(string ISBN13)
        {
            Book book = Data.Find(book1 => book1.ISBN13.Contains(ISBN13));
            if (book == null) return null;
            Data.Remove(book);
            return book;
        }
    }
}

