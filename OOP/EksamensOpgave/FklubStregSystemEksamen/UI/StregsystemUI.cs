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
        }

        public event StregsystemEvent CommandEntered;

        public void Close()
        {
            throw new NotImplementedException();
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
        }

        public void DisplayUserBuysProduct(List<BuyTransaction> transactions)
        {
            foreach (Transaction trans in transactions)
            {
                Console.WriteLine(trans);
            }
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
                Console.WriteLine("Enter Command:");
                string command = Console.ReadLine();
                CommandEntered("Hej");
            }
        }
    }
}
