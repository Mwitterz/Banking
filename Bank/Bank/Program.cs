using Banking.Models;
using System;
using System.Linq;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("123-123123-12");
            Console.WriteLine($"Account number: {myAccount.AccountNumber}");
            Console.WriteLine($"Account balance: {myAccount.Balance}");
            myAccount.Deposit(200M);
            Console.WriteLine($"Account balance after deposit of 200€: {myAccount.Balance}");
            Console.WriteLine($"Number of transactions after deposit: {myAccount.NumberOfTransactions}");
            myAccount.Withdraw(100M);
            Console.WriteLine($"Account balance after withdrawal of 100€: {myAccount.Balance}");
            Console.WriteLine($"Number of transactions after withdrawal: {myAccount.NumberOfTransactions}");
            int aantal = myAccount.GetTransactions(DateTime.Today.AddDays(-2), DateTime.Today).Count();
            Console.WriteLine($"Aantal transacies: {aantal}");

            Console.Read();
        }
    }
}
