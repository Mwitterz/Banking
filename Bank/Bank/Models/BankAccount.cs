using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
        public string AccountNumber
        {
            get { return _accountNumber;}
            set
            {
                Regex regex = new Regex(@"(\d{3})-(\d{7})-(\d{2})");
                Match match = regex.Match(value);
                if(!match.Success)
                    throw new ArgumentException("Bankaccount numer format is nog correct");
                if (int.Parse(match.Groups[1] + match.Groups[2].ToString()) % 97 !=
                    int.Parse(match.Groups[3].ToString()))
                    throw new ArgumentException("97 test of the bankaccount number failed");
                _accountNumber = value;
            }
             }

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
