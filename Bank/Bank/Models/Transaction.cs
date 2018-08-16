using System;

namespace Banking.Models
{
    public class Transaction
    {
        private decimal _amount;


        public decimal Amount { get => _amount; private set => _amount = value; }
        public DateTime DateOfTrans { get; private set; }
        public bool IsDeposit {
            get
            {
                return TransactionType == TransactionType.Deposit;
            }
        } 
        public bool IsWithdraw
        {
            get
            {
                return TransactionType == TransactionType.Withdraw;
            }
        } 
        public TransactionType TransactionType { get; set; }

        public Transaction(decimal amount, TransactionType type)
        {
            Amount = amount;
            DateOfTrans = new DateTime();
            TransactionType = type;
        }
    }
}