using System;
using System.Collections.Generic;
using System.Text;
using FklubStregSystemEksamen.Exceptions;

namespace FklubStregSystemEksamen.Data
{
    class InsertCashTransaction : Transaction
    {
        public InsertCashTransaction(User user, DateTime date, int amount) : base(user, date)
        {
            Amount = amount;
        }

        public override void Execute()
        {
            if (Amount > 0)
            {
                User.Balance += Amount;
            } else
            {
                throw new InvalidInputException($"Input cannot be negative. Input: {Amount}. user balance is {User.Balance}");
            }
            
        }
        public override string ToString()
        {
            return $"{Amount} inserted into the account of {User.Username} on {Date}. (Transaction ID: {ID})";
        }
    }
}
