// See https://aka.ms/new-console-template for more information
using BankAccount;
using System.Transactions;

Console.WriteLine("Welcome to EPAM Bank:");
Console.WriteLine("Enter owner name");
string? name=Console.ReadLine();
Console.WriteLine("Enter Initial Deposit Amount:");
double amt= Console.Read();
var u1 = new Account(name,amt);
while (true)
{
    Console.WriteLine("Choose:\n0.Deposit\n1.Withdraw\n2.Enquiry");
    int n = int.Parse(Console.ReadLine());
    switch (n)
    {
        case 0:
            Console.WriteLine("Enter Amount to be Deposited:");
            int x = int.Parse(Console.ReadLine());
            u1.deposit(x);
            break;
        case 1:
            Console.WriteLine("Enter Amount to be Withdrawn:");
            int x1 = int.Parse(Console.ReadLine());
            u1.withdraw(x1);
            break; 
        case 2:
            Console.WriteLine("Fetching User details:");
            u1.Enquiry();
            break;
        default:
            return;
    }
}
