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
            Student s1 = new Student("Ryan","Palmer","54092401",3.6f);
            Console.WriteLine(s1);

            Vehicle v1 = new Vehicle("Nissan", "Sentra", 2016, 402.4f);
            Console.WriteLine(v1);
        }
    }
}
