namespace Banking.Models
{
    class SavingsAccount :BankAccount
    {
        protected const decimal WithdrawCost = 0.25M;

        public decimal InterestRate { get; private set; }
        public SavingsAccount(string accountNumber, decimal interestRate) : base(accountNumber)
        {
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            Deposit(Balance * InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            base.Withdraw(WithdrawCost);
        }
    }
}
