using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }
       
        //ctors
        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }

        public Student()
        {

        }
        //methods
        public override string ToString()
        {
            return string.Format("Name: {0} {1}\n" +
                "ID: {2}\n" +
                "GPA: {3}\n",
                FirstName, LastName, Id, Gpa);
        }

    }
}
