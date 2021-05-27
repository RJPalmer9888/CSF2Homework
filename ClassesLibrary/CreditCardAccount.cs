using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //fields
        private int _accountNumber;
        private Customer _customerInfo;
        private decimal _balance;
        private bool _isPastDue;
        private decimal _annualInterestRate;

        //properties
        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public Customer CustomerInfo
        {
            get { return _customerInfo; }
            set { _customerInfo = value; }
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public bool IsPastDue
        {
            get { return _isPastDue; }
            set { _isPastDue = value; }
        }
        public decimal AnnualInterestRate
        {
            get { return _annualInterestRate; }
            set { _annualInterestRate = value; }
        }
       
        //ctors
        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public CreditCardAccount()
        {

        }
        //methods
        public override string ToString()
        {
            return string.Format("Account {0} \n" +
                "{1}" +
                "Balance: {2:c}\n" +
                "{3}\n" +
                "Annual Interest Rate: {4}\n",
                AccountNumber, CustomerInfo, Balance, IsPastDue ? "Past due" : "Paid", AnnualInterestRate);
        }

    }
}
