using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.SRP
{
    // separating class to perform different tasks
    
    // class to perform transaction of amount credit
    class CreditAmount
    {
        public void creditAmount(int amt)
        {
            if (amt > 0 && amt < 50000)
            {
                // code to credit amount to bank account
            }
        }
    }

    // class to perform transaction of amount debit
    class WithdrawAmount
    {
        public double Amount { get; set; }
        public void debitAmount(int amt)
        {
            if (amt > 0 && amt < Amount)
            {
                // code to withdraw amount from bank account
            }
        }
    }

    // class to fetch bank balance from the database and display to the user
    class DisplayAmount
    {
        public void displayAmount(int account_no)
        {
            Console.WriteLine($"Your bank balance is...");
        }
    }
}
