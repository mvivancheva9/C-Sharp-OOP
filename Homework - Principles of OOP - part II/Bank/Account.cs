using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account : IDeposit
    {
        //fields
        private Customer customerType;
        private decimal balance;
        private decimal interestRate;

        
        //constructors
        public Account(Customer customerType, decimal balance, decimal interestRate)
        {
            this.CustomerType = customerType;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        //encapsulation
        public Customer CustomerType
        {
            get { return this.customerType; }
            set { this.customerType = value; }
        }
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        //methods
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The deposit shout be mote than 0!");
            }
            this.Balance += amount;
        }

        public abstract decimal InterestAmount(int numberOfMonths);
        public override string ToString()
        {
            return string.Format("The customer is: {0}, with balance of: [{1}], and interest rate: [{2}]", this.CustomerType, this.Balance, this.InterestRate);
        }
    }
}
