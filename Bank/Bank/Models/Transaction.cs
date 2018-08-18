using System;

namespace Banking.Models
{
    public class Transaction
    {
        
        
        #region Properties

        public decimal Amount { get ; private set ; }
        public DateTime DateOfTrans { get; private set; }
        public TransactionType TransactionType { get; private set; }

        #endregion 


        #region Methods
        public bool IsDeposit
        {
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
        #endregion



        #region Constructors
        public Transaction(decimal amount, TransactionType type)
        {
            //if (((type == TransactionType.Deposit) && (amount < 0)))||((type == TransactionType.Withdraw)&&(amount))
            if (amount <0)
            {
                throw new ArgumentException("Amount can not be negative");
            }
            Amount = amount;
            DateOfTrans = DateTime.Today;
            TransactionType = type;
        }
        #endregion
    }
}