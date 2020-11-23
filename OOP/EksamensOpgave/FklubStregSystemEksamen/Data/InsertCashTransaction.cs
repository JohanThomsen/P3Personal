using System;
using System.Collections.Generic;
using System.Text;
using FklubStregSystemEksamen.Exceptions;

namespace FklubStregSystemEksamen.Data
{
    public class InsertCashTransaction : Transaction
    {
        public InsertCashTransaction(int id, User user, DateTime date, decimal amount) : base(id, user, date)
        {
            Amount = amount;
        }

        public override bool Execute()
        {
            bool success = false;
            if (Amount > 0)
            {
                success = true;
                User.Balance += Amount;
            } else
            {
                throw new InvalidInputException($"Input cannot be negative. Input: {Amount}. user balance is {User.Balance}");
            }
            return success;
        }
        public override string LogToString()
        {
            return $"{base.LogToString()},Insert,{Amount}";
        }

        public override string ToString()
        {
            return $"{Amount} inserted into the account of {User.Username} on {Date}. (Transaction ID: {ID})";
        }
    }
}
