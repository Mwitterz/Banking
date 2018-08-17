using System;
using System.Collections.Generic;

namespace Banking.Models
{
    public class BankAccount : IBankAccount
    {
        #region fields
        private string _accountNumber;
        private IList<Transaction> _transactions;
        
        #endregion

        #region Constructors
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = Decimal.Zero;
            _transactions = new List<Transaction>();
        }
        #endregion
        //hier iets aanpassen


        #region Properties
        

        public decimal Balance { get; set; }
        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }

        public int NumberOfTransactions
        {
            get { return _transactions.Count;}

        }
        #endregion

        #region Methods
        public  void Deposit(decimal amount)
        {
            Balance += amount;
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
        }

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
        }
    

        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till)
        {
            IList<Transaction> transList = new List<Transaction>();
            foreach (Transaction transaction in _transactions)
            {
                if(transaction.DateOfTrans>= from && transaction.DateOfTrans <= till)
                {
                    transList.Add(transaction);
                }
            }

            return transList;
        }
        #endregion

        public override string ToString()
        {
            return $"{AccountNumber} - {Balance}";
        }

        public override bool Equals(object obj)
        {
            BankAccount account = obj as BankAccount;
            if (account == null) return false;
            return AccountNumber == account.AccountNumber;
        }

        public override int GetHashCode()
        {
            return AccountNumber?.GetHashCode() ?? 0;
        }
    }
}
