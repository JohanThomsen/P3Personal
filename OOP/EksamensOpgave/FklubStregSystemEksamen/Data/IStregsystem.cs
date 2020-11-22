using System;
using System.Collections.Generic;
using System.Text;

namespace FklubStregSystemEksamen.Data
{
    public interface IStregsystem
    {
            IEnumerable<Product> ActiveProducts { get; }
            InsertCashTransaction AddCreditsToAccount(User user, decimal amount);
            BuyTransaction BuyProduct(User user, Product product);
            Product GetProductByID(int id);
            IEnumerable<Transaction> GetTransactions(User user, int count);
            IEnumerable<User> GetUsers(Predicate<User> pred);
            User GetUserByUsername(string username);
            bool ExecuteTransaction(Transaction trans);
            event UserBalanceNotification UserBalanceWarning;
    }
}
