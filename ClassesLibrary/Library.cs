using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //fields

        //properties
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        //ctors
        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        //methods
        public override string ToString()
        {
            string catalog = "";

            foreach (Book book in Books)
            {
                catalog += book + "\n";
            }

            //return base.ToString();
            return string.Format("{0}\n\nAddress:\n{1}\n{2}, {3} {4}\n\nBooks:\n{5}\n",
                LibraryName, StreetAddress, City, State, Zip, catalog);
        }
    }
}
