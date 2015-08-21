using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class MorgageAccount : Account
    {
        //constructors
        public MorgageAccount(Customer customerType, decimal balance, decimal interestRate)
            : base(customerType, balance, interestRate)
        {

        }
        //methods
        public override decimal InterestAmount(int numberOfMonths)
        {
            decimal interestAmount = 0.0M;
            if (this.CustomerType == Customer.company)
            {
                if (numberOfMonths <= 12)
                {
                    interestAmount = numberOfMonths * (0.5M * this.InterestRate / 100M) * this.Balance;
                }
                else
                {
                    interestAmount = ((12 * (0.5M * this.InterestRate / 100M) * this.Balance) +
                        (this.InterestRate / 100M * (numberOfMonths - 12)) * this.Balance);
                }
            }
            else
            {
                if (numberOfMonths <= 6)
                {
                    interestAmount = 0.0M;
                }
                else
                {
                    interestAmount = this.InterestRate / 100M * (numberOfMonths - 6) * this.Balance;
                }
            }
            return interestAmount; 
        }
    }
}
