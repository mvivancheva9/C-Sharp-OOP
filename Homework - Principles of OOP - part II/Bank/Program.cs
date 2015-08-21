using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main()
        {
            List<Account> allAccounts = new List<Account>();

            Account morgageCompany1 = new MorgageAccount(Customer.company, 569.66M, 2.3M);
            morgageCompany1.Deposit(1000M);
            Account loanIndividual = new LoanAccount(Customer.individual, 896.366M, 5.66M);
            Account depositCompany = new DepositAccount(Customer.company, 4569.55M, 8.3M);
            allAccounts.Add(morgageCompany1);
            allAccounts.Add(loanIndividual);
            allAccounts.Add(depositCompany);
            PrintAccounts(allAccounts);
        }
        public static void PrintAccounts(IEnumerable<Account> allAccounts)
        {
            //LINQ
            var printAccounts =
                 from account in allAccounts
                 select account;
            Console.WriteLine("Accounts:");
            ToString(printAccounts);
        }
        public static void ToString(IEnumerable<Account> allAccounts)
        {
            foreach (var account in allAccounts)
            {
                Console.WriteLine(account);
                Console.WriteLine("Interest Amount for 24 months: {0:F2}", account.InterestAmount(24));
                Console.WriteLine("Interest Amount for 4 months: {0:F2}\n", account.InterestAmount(4));
            }
        }
    }
}
