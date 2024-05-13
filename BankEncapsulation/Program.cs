using Microsoft.VisualBasic;
using System.Diagnostics.Contracts;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            var balance = account.CheckBalance();
            Console.WriteLine($"Your account balance is ${balance}.");
            Console.WriteLine($"How much would you like to deposite?");

            account.Deposite(50);
            Console.WriteLine($"You deposited $50.");

            balance = account.CheckBalance();
            Console.WriteLine($"Your current account balance is now ${balance}.");

        }
    }
    




}
