using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Opgaver
{
    class BankAccount
    {
        private decimal _balance;
        public decimal Balance 
        {
            get { return _balance; }  
        }
        public BankAccount(int balance)
        {
            try
            {
                if (balance < 0)
                {
                    throw new InsufficientFundsException("Balance must be greater than 0");
                }
            }
            catch (InsufficientFundsException FundsException)
            {
                Console.WriteLine(FundsException.Message);
            }
            finally 
            {
                _balance = balance;
                Console.WriteLine($"New account created with {_balance} dkk");
            }
        }

        public void Deposit(decimal Deposit)
        {
            decimal newBalance = _balance += Deposit;
            try
            {
                if (newBalance < 0)
                {
                    throw new InsufficientFundsException("Balance must be greater than 0");
                } else
                {
                    _balance = newBalance;
                    Console.WriteLine($"Your new balance is {_balance}");
                }
            }
            catch (InsufficientFundsException FundsException)
            {
                Console.WriteLine(FundsException.Message);
            }   
        }

        public void Withdraw(decimal Withdrawal)
        {
            decimal newBalance = _balance -= Withdrawal;
            try
            {
                if (newBalance < 0)
                {
                    throw new InsufficientFundsException("Balance must be greater than 0");
                } else
                {
                    _balance = newBalance;
                    Console.WriteLine($"Your new balance is {_balance}");
                }
            }
            catch (InsufficientFundsException FundsException)
            {
                Console.WriteLine(FundsException.Message);
            }   
        }
    }
}
