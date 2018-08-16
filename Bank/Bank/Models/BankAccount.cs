using System;

namespace Banking.Models
{
    public class BankAccount
    {
        #region fields
        private string _accountNumber;
        // test commit
        #endregion

        #region Constructors
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = Decimal.Zero;
        }
        #endregion


        #region Properties
        

        public decimal Balance { get; set; }
        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }

        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}
