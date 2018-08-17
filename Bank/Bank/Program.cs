using Banking.Models;
using System;
using System.Linq;

namespace Banking
{
    class Program
    {
        static void Main()
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

            SavingsAccount saving = new SavingsAccount("123-123123-12",0.01M);
            saving.Deposit(200M);
            saving.Withdraw(100M);
            saving.AddInterest();
            Console.WriteLine($"Balance savingsaccount: {saving.Balance}");
            Console.Write(saving);

            Console.Read();
        }
    }
}
