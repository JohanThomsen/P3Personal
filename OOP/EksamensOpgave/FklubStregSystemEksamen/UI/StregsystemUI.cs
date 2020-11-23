using FklubStregSystemEksamen.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FklubStregSystemEksamen.UI
{
    public class StregsystemUI : IStregsystemUI
    {
        public IStregsystem Stregsystem { get; set; }

        public StregsystemUI(IStregsystem stregsystem)
        {
            Stregsystem = stregsystem;
            stregsystem.UserBalanceWarning += DisplayUserBalanceWarning;
        }

        public void DisplayUserBalanceWarning(User user, decimal balance)
        {
            Console.WriteLine($"User {user.Username} low. Balance is {user.Balance}");
        }

        public event StregsystemEvent CommandEntered;

        public void Close()
        {
            Environment.Exit(0);
        }

        public void DisplayAdminCommandNotFoundMessage(string adminCommand)
        {
            Console.WriteLine($"The admin command: {adminCommand} was not found");
        }

        public void DisplayGeneralError(string errorString)
        {
            Console.WriteLine($"An unknown error occured: {errorString}");
        }

        public void DisplayInsufficientCash(string error)
        {
            Console.WriteLine(error);
        }

        public void DisplayProductNotFound(string error)
        {
            Console.WriteLine(error);
        }

        public void DisplayTooManyArgumentsError(string command)
        {
            Console.WriteLine($"The commmand: '{command}' has too many arguments");
        }

        public void DisplayUserBuysProduct(BuyTransaction transaction)
        {
            Console.WriteLine(transaction);
            Console.WriteLine($"new balance is {transaction.User.Balance}");
        }

        public void DisplayUserBuysProduct(List<BuyTransaction> transactions)
        {
            decimal userBalance = -1;
            foreach (Transaction trans in transactions)
            {
                Console.WriteLine(trans);
                userBalance = trans.User.Balance;
            }
            Console.WriteLine($"new balance is {userBalance}");
        }

        public void DisplayUserInfo(User user)
        {
            Console.WriteLine(user);
        }

        public void DisplayUserNotFound(string error)
        {
            Console.WriteLine(error);
        }

        public void Start()
        {
            while (true)
            {
                showUI();
                HandleInput();
            }
        }

        private void HandleInput()
        {
            Console.WriteLine("Enter Command:");
            string command = Console.ReadLine();
            Console.Clear();
            CommandEntered?.Invoke(command);
        }

        private void showUI()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Choose a product to buy");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            IEnumerable<Product> activeproducts = Stregsystem.ActiveProducts;

            foreach (Product prod in activeproducts)
            {
                Console.WriteLine(prod);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }
    }
}
