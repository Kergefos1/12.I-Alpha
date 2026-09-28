using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        private int _pageCount;
        public int PageCount { get { return _pageCount; } set { if (value < 0) { _pageCount = 0; } else { _pageCount = value; } } }

        public static int Count = 0;
        public bool IsAvalable = true;
        public Book(string title, string auther, int pagecount)
        {
            Title = title;
            Auther = auther;
            PageCount = pagecount;
            Count++;

        }

        public void Descripe()
        {
            Console.WriteLine(Title + " " + Auther + " " + PageCount+ " "+ Count);
        }

        public bool IsLong()
        {
            return PageCount > 300;
        }
        public Book(string title, string auther)
        {
            Title = title;
            Auther = auther;
            PageCount = 0;
            Count++;
        }
        public bool Borrow()
        {
            if(IsAvalable)
            {
                IsAvalable = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Return()
        {
            IsAvalable = true;
        }


        
    }
}
