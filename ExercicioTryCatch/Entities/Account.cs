using System;
using ExercicioTryCatch.Entities.Exceptions;

namespace ExercicioTryCatch.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(Balance == 0)
            {
                throw new DomainException("No balance in account");

            }
            else if(amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw limit surpassed");

            }
            else if(amount > Balance)
            {
                throw new DomainException("Not enough balance");

            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return "New balance: " + Balance.ToString("F2");
        }
    }
}
