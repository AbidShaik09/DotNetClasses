using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Account
    {
        double mainBalance;
        String? ownerName;
        

        internal Account(string? ownerName,double mainBalance)
        {
            this.ownerName = ownerName;
            this.mainBalance = mainBalance;
            
        }
        public void withdraw(int x)
        {
            if (x > mainBalance)
            {
                Console.WriteLine("Error: Insufficient fund");
            }
            else
            {
                mainBalance -= x;
                Console.WriteLine("Successful: Remaining Balance= "+mainBalance);
            }
        }
        public void deposit(int x)
        {
            mainBalance += x;
            Console.WriteLine(x+" Rs Deposited Successfully");

        }
        public void Enquiry()
        {
            Console.WriteLine("Account name : "+ownerName+"\nBalance: "+mainBalance);
        }

        /*  owner name, Main balance,remaining balance, withdraw ,deposit, main balance  */
    }
}
