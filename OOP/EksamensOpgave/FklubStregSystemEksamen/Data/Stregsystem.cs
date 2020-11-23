using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FklubStregSystemEksamen.Exceptions;

namespace FklubStregSystemEksamen.Data
{
    public class Stregsystem : IStregsystem
    {
        public DatabaseAccess DaAccess;
        public Stregsystem(DatabaseAccess daAccess)
        {
            DaAccess = daAccess;
        }

        public event UserBalanceNotification UserBalanceWarning;

        public BuyTransaction BuyProduct(User user, Product product)
        {
            return new BuyTransaction(DaAccess.Transid.Next(), user, DateTime.Now, product);       
        }

        public InsertCashTransaction AddCreditsToAccount(User user, decimal Amount)
        {
            return new InsertCashTransaction(DaAccess.Transid.Next(), user, DateTime.Now, Amount);
        }

        public bool ExecuteTransaction(Transaction trans)
        {
            bool success = trans.Execute();
            if (success == true)
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Git\P3\Personal\OOP\EksamensOpgave\FklubStregSystemEksamen\Data\Transactions.txt", true))
                {
                    file.WriteLine(trans.LogToString());
                }
            }
            return success;
        }

        public Product GetProductByID(int id)
        {
            Product foundProduct = null;
            foreach (Product product in DaAccess.products)
            {
                if (product.ID == id)
                {
                    foundProduct = product;
                    return foundProduct;
                }
            }

            if (foundProduct == null)
            {
                throw new ProductNotFoundException($"Product with ID: {id} not found");
            } 
            else
            {
                return foundProduct;
            }
        }

        public IEnumerable<User> GetUsers(Predicate<User> pred)
        {
            return DaAccess.users.Where(user => pred(user));
        }

        public User GetUserByUsername(string username)
        {
            User foundUser = null;
            foreach (User user in DaAccess.users)
            {
                if (user.Username == username)
                {
                    foundUser = user;
                }
            }

            if (foundUser == null)
            {
                throw new UserNotFoundException($"User with username: {username} not found");
            }
            else
            {
                return foundUser;
            }
        }

        public IEnumerable<Transaction> GetTransactions (User user, int count)
        {
            return DaAccess.transactions.Take(count).Where(trans => trans.User.Username == user.Username).OrderBy(trans => trans.Date);
        }

        public IEnumerable<Product> ActiveProducts => DaAccess.products.Where(prod => prod.IsActive);
    }
}
