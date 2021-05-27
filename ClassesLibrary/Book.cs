using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //fields

        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        //ctors
        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public Book()
        {

        }

        //methods
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Title: {0}\nAuthor: {1}\nPages: {2}",
                Title, Author, NumberOfPages);
        }
    }
}
