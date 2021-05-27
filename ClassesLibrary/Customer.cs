using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _customerId;
        private ContactInfo _contactInformation;

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
        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
        public ContactInfo ContactInformation
        {
            get { return _contactInformation; }
            set { _contactInformation = value; }
        }
       
        //ctors
        public Customer(string firstName, string lastName, string customerId, ContactInfo contactInformation)
        {
            FirstName = firstName;
            LastName = lastName;
            CustomerId = customerId;
            ContactInformation = contactInformation;
        }

        public Customer()
        {

        }
        //methods
        public override string ToString()
        {
            return string.Format("Name: {0} {1}\n" +
                "Customer ID: {2}\n" +
                "Contact Information: \n{3}\n",
                FirstName, LastName, CustomerId, ContactInformation);
        }

    }
}
