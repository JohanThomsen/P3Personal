using System;
using System.Collections.Generic;
using System.Text;
using FklubStregSystemEksamen.Exceptions;
namespace FklubStregSystemEksamen.Data
{
    class BuyTransaction : Transaction
    {
        private Product Product;

        public BuyTransaction(User user, DateTime date, Product product) : base(user, date)
        {
            Product = product;
            Amount = product.Price;
        }

        public override string ToString()
        {
            return $"{Product.Name} has been bought by {User.Username} for {Amount} Kr. on {Date}. (Transaction ID: {ID})";
        }

        public override void Execute()
        {
            if (Amount < 0)
            {
                User.Balance -= Amount;
            }
            else
            {
                throw new InvalidInputException($"Input cannot be positive. Input: {Amount}. user balance is {User.Balance}");
            }
        }
    }
}
