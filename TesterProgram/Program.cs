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
            Console.WriteLine("Students");
            Student s1 = new Student("Ryan","Palmer","54092401",3.6f);
            Student s2 = new Student();
            s2.FirstName = "Dababy";
            s2.LastName = "lesgo";
            s2.Id = "213931";
            s2.Gpa = 2.9f;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();

            Console.WriteLine("Vehicles");
            Vehicle v1 = new Vehicle("Nissan", "Sentra", 2016, 402.4f);
            Vehicle v2 = new Vehicle();
            v2.Make = "Hyundai";
            v2.Model = "Sonata";
            v2.Year = 2018;
            v2.Weight = 386.2f;
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine();

            Console.WriteLine("Logins");
            Login l1 = new Login("YaBoi17", "cranked");
            Login l2 = new Login();
            l2.Username = "Dababy";
            l2.Password = "lesgo";
            Console.WriteLine(l1);
            Console.WriteLine(l2);

            Console.WriteLine("Contact Information");
            Console.WriteLine();
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
        }
    }
}
