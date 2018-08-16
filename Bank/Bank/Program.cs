using Banking.Models;
using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("123-123123-12");
            Console.WriteLine($"Account number: {myAccount.AccountNumber}");
            Console.WriteLine($"Account balance: {myAccount.Balance}");
            myAccount.Deposit(100M);
            Console.WriteLine($"Account balance after deposit: {myAccount.Balance}");
            Console.Write("Test, zien of ik de changes sopmerk");


            Console.Read();
        }
    }
}
