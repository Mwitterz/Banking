using System;
using System.Collections.Generic;

namespace Banking.Models
{
    public interface IBankAccount
    {
        decimal Balance { get; set; }
        string AccountNumber { get; set; }
        int NumberOfTransactions { get; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till);
    }
}