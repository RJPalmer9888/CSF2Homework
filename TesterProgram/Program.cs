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
        }
    }
}
