using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class DepositAccount : Account, IWithDraw
    {
        //constructors
        public DepositAccount(Customer customerType, decimal balance, decimal interestRate)
            : base(customerType, balance, interestRate)
        {

        }
        //methods
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The withdraw shout be more than 0!");
            }
            this.Balance -= amount;
        }
        public override decimal InterestAmount(int numberOfMonths)
        {
            decimal interestAmount = 0.0M;
            if (this.Balance > 0 && this.Balance < 1000)
            {
                interestAmount = 0.0M;
            }
            else
            {
                interestAmount = (numberOfMonths * this.InterestRate / 100M) * this.Balance;
            }
            return interestAmount; 
        }
    }
}