using System;
using Xunit;
using Banking.Models;

namespace BankTests.Models
{
    public class BankAccountTest : IDisposable
    {
        private BankAccount _account;
        public string AccountNumber { get; set; }


        public BankAccountTest()
        {
            AccountNumber = "123-4567890-02";
            _account = new BankAccount(AccountNumber);
        }

        public void Dispose()
        {

        }

        [Fact]
        public void NewAccount_BalanceZero()
        {
            Assert.Equal(0, _account.Balance);
        }

        [Fact]
        public void NewAccount_CorrectAccountnumber()
        {
            //Asses
            Assert.Equal(AccountNumber, _account.AccountNumber);
        }

        [Fact]
        public void NewAccount_EmptyString_Fails()
        {
            AccountNumber = "";
            Assert.Throws<ArgumentException>(() => new BankAccount(String.Empty));
        }
    }
}
