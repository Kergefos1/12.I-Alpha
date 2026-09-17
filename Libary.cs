using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Libary
    {
        public string Name { get; set; }
        private List<Book> _books { get; set; }
        public int BookCount { get; }

        public Libary(string name)
        {
            Name = name;
            _books = new List<Book>();
            BookCount = _books.Count;
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void PrintAll()
        {
            foreach (Book book in _books)
            {
                book.Descripe();
            }
        }

        public string FindByTitle(string title)
        {
            return title;
        }
    }
}
