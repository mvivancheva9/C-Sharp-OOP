using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class LoanAccount : Account
    {
        //constructors
        public LoanAccount(Customer customerType, decimal balance, decimal interestRate)
            : base(customerType, balance, interestRate)
        {

        }
        //methods
        public override decimal InterestAmount(int numberOfMonths)
        {
            decimal interestAmount = 0.0M;
            if (this.CustomerType == Customer.company)
            {
                if (numberOfMonths <= 2)
                {
                    interestAmount = 0.0M;
                }
                else
                {
                    interestAmount = (this.InterestRate / 100M * (numberOfMonths - 2)) * this.Balance;
                }
            }
            else
            {
                if (numberOfMonths <= 3)
                {
                    interestAmount = 0.0M;
                }
                else
                {
                    interestAmount = this.InterestRate / 100M * (numberOfMonths - 3) * this.Balance;
                }
            }
            return interestAmount; 
        }
    }
}