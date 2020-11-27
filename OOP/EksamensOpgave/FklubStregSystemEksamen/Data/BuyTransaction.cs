using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using FklubStregSystemEksamen.Exceptions;
namespace FklubStregSystemEksamen.Data
{
    public class BuyTransaction : Transaction
    {
        private Product Product;

        public BuyTransaction(int id, User user, DateTime date, Product product) : base(id, user, date)
        {
            Product = product;
            Amount = product.Price;
        }

        public override bool Execute()
        {
            bool success = false;
            if (Amount > 0)
            {
                if ((User.Balance >= Amount) && (Product.CanBeBoughtOnCredit == false))
                {
                    success = true;
                    User.Balance -= Amount;
                } else if (Product.CanBeBoughtOnCredit == true)
                {
                    success = true;
                    User.Balance -= Amount;
                } else
                {
                    throw new InsufficientFundsException($"{User.Username} does not have enough funds to buy {Product.Name}. User Balance : {User.Balance} | Product price : {Product.Price}");
                }    
            }
            else
            {
                throw new InvalidInputException($"Input cannot be negative. Input: {Amount}. user balance is {User.Balance}");
            }
            return success;
        }

        public override string ToString()
        {
            return $"{Product.Name} has been bought by {User.Username} for {Amount} Kr. on {Date}. (Transaction ID: {ID})";
        }

        public override string LogToString()
        {
            return $"{base.LogToString()};Buy;{Product.ID};{Product.Name};{(Product.Price * 100).ToString("F0", CultureInfo.InvariantCulture)};{(Product.IsActive == true ? 1 : 0)}"; 
        }
    }
}
