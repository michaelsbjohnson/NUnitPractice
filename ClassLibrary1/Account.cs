using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class Account
    {
        private decimal minimumBalance = 10m;
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount)
        {
            if (this.Balance - amount < this.MinimumBalance)
            {
                throw new InsufficientFundsException();
            }
            destination.Deposit(amount);
            this.Withdraw(amount);
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
        }

        public decimal MinimumBalance
        {
            get
            {
                return minimumBalance;
            }
        }
    }
}
