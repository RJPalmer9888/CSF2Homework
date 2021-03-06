using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Students\n");

            Student s1 = new Student("Ryan","Palmer","54092401",3.6f);
            Student s2 = new Student();
            s2.FirstName = "Dababy";
            s2.LastName = "lesgo";
            s2.Id = "213931";
            s2.Gpa = 2.9f;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Vehicles\n");

            Vehicle v1 = new Vehicle("Nissan", "Sentra", 2016, 402.4f);
            Vehicle v2 = new Vehicle();
            v2.Make = "Hyundai";
            v2.Model = "Sonata";
            v2.Year = 2018;
            v2.Weight = 386.2f;
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Logins\n");

            Login l1 = new Login("YaBoi17", "cranked");
            Login l2 = new Login();
            l2.Username = "Dababy";
            l2.Password = "lesgo";
            Console.WriteLine(l1);
            Console.WriteLine(l2);

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Contact Information\n");

            ContactInfo c1 = new ContactInfo("2832 Fairway Drive", "Belleville", "IL", "62220", "618-531-2417", "phoenixpalmer88@gmail.com");
            ContactInfo c2 = new ContactInfo();
            c2.StreetAddress = "6 Campus Edge Drive";
            c2.City = "Edwardsville";
            c2.State = "IL";
            c2.Zip = "62025";
            c2.Phone = "618-531-2417";
            c2.Email = "rjpalmer9888@gmail.com";
            Console.WriteLine(c1);
            Console.WriteLine();
            Console.WriteLine(c2);

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Customers\n");

            Customer cs1 = new Customer("Kelly", "Palmer", "CSTM1830", c1);
            Customer cs2 = new Customer();
            cs2.FirstName = "Ryan";
            cs2.LastName = "Palmer";
            cs2.CustomerId = "CSTM2173";
            cs2.ContactInformation = c2;
            Console.WriteLine(cs1);
            Console.WriteLine();
            Console.WriteLine(cs2);

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Credit Card Accounts\n");

            CreditCardAccount cr1 = new CreditCardAccount(13921239, cs1, 2600, true, .05m);
            CreditCardAccount cr2 = new CreditCardAccount();
            cr2.AccountNumber = 13929921;
            cr2.CustomerInfo = cs2;
            cr2.Balance = 900;
            cr2.IsPastDue = false;
            cr2.AnnualInterestRate = .07m;
            Console.WriteLine(cr1);
            Console.WriteLine();
            Console.WriteLine(cr2);

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Books\n");

            Book b1 = new Book("Empire","Orson Scott Card", 352);
            Book b2 = new Book();
            b2.Title = "Hunger Games";
            b2.Author = "Jennifer Lawrence";
            b2.NumberOfPages = 300;
            Console.WriteLine(b1);
            Console.WriteLine();
            Console.WriteLine(b2);

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Library\n");
            List<Book> books = new List<Book>() { b1, b2 };
            Library li1 = new Library(books,"Books R Us","1 Lemon Tree Rd","Montgomery","Alabama", "72940");
            Console.WriteLine(li1);

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Songs\n");

            Song so1 = new Song("Blockbuster Night Pt. 1", "Run The Jewels", 145);
            Song so2 = new Song("2100", "Run The Jewels", 182);
            Console.WriteLine(so1);
            Console.WriteLine(so2);

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Artists\n");
            List<Song> tracks = new List<Song>() { so1, so2 };
            Artist ar1 = new Artist(tracks, "Run The Jewels", "Hip Hop");
            Console.WriteLine(ar1);

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Motor Home\n");
            MotorHome mh1 = new MotorHome("Winnebega", "Hoopdee", 2004, 803.6f, 4);
            Console.WriteLine(mh1);

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Truck\n");
            Truck tr1 = new Truck("Ford", "F-150", 2004, 322.6f, 140.0f);
            Console.WriteLine(tr1);
        }
    }
}
