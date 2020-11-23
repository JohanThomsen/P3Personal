using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using FklubStregSystemEksamen.Data;
using FklubStregSystemEksamen.Exceptions;

namespace FklubStregSystemEksamen.UI
{
    public class StregSystemController
    {
        public StregSystemController(IStregsystemUI ui, IStregsystem core)
        {
            Ui = ui;
            Core = core;
            Ui.CommandEntered += ParseCommand;
        }

        public IStregsystemUI Ui { get; set; }
        public IStregsystem Core { get; set; }

        public void ParseCommand(string command)
        {
            Regex buyMatch = new Regex("[\\a-zæøåA-ZÆØÅ]+[\\s][\\d]+"); //[[\a-zæøåA-ZÆØÅ]]+[\s][\d]+ Tjekker efter et navn efterfulgt af et space og et tal
            Regex multiBuyMatch = new Regex("[\\a-zæøåA-ZÆØÅ]+[\\s][\\d]+[\\s][\\d]+"); //[[\a-zæøåA-ZÆØÅ]]+[\s][\d]+[\s][\d]+ Tjekker efter et navn efterfulgt af et space og tal med space imellem 2 tal
            Regex accountMatch = new Regex("^[\\a-zæøåA-ZÆØÅ$]+"); //[[\a-zæøåA-ZÆØÅ]]+ Tjekker efter at der kun er en string

            if (command.StartsWith(":"))
            {
                ParseAdminCommands(command);
            }else
            {
                try
                {
                    if (multiBuyMatch.IsMatch(command))
                    {
                        GetAndShowMultiBuy(command);
                    }
                    else if (buyMatch.IsMatch(command))
                    {
                        GetAndShowBuy(command);
                    }
                    else if (accountMatch.IsMatch(command))
                    {
                        GetAndShowAccountInfo(command);
                    }
                    else
                    {
                        throw new InvalidInputException($"The input {command} is invalid");
                    }
                }
                catch (Exception e)
                {
                    Ui.DisplayGeneralError(e.Message);
                }

                void GetAndShowAccountInfo(string command)
                {
                    bool success = false;
                    User user = default;
                    try
                    {
                        success = true;
                        user = Core.GetUserByUsername(command);
                    }
                    catch (UserNotFoundException e)
                    {
                        Ui.DisplayUserNotFound(e.Message);
                    }

                    if (success == true)
                    {
                        Ui.DisplayUserInfo(user);
                    }
                }
            }

            
        }

        private void GetAndShowBuy(string command)
        {
            string[] split = command.Split(' ');
            string username = split[0];
            int productID = Convert.ToInt32(split[1]);
            bool success = false;

            BuyTransaction trans = Core.BuyProduct(Core.GetUserByUsername(username), Core.GetProductByID(productID));
            try
            {
                success = Core.ExecuteTransaction(trans);
            }
            catch (UserNotFoundException e)
            {
                Ui.DisplayUserNotFound(e.Message);
            }
            catch (ProductNotFoundException e)
            {
                Ui.DisplayProductNotFound(e.Message);
            }
            catch (InsufficientFundsException e)
            {
                Ui.DisplayInsufficientCash(e.Message);
            }

            if (success == true)
            {
                Ui.DisplayUserBuysProduct(trans);
            }
        }

        private void GetAndShowMultiBuy(string command)
        {
            string[] split = command.Split(' ');
            string username = split[0];
            int count = Convert.ToInt32(split[1]);
            int productID = Convert.ToInt32(split[2]);
            List<BuyTransaction> transactions = new List<BuyTransaction>();
            bool success = false;

            for (int i = 0; i < count; i++)
            {
                transactions.Add(Core.BuyProduct(Core.GetUserByUsername(username), Core.GetProductByID(productID)));
            }

            try
            {
                foreach (Transaction transaction in transactions)
                {
                    success = transaction.Execute();
                }
            }
            catch (UserNotFoundException e)
            {
                Ui.DisplayUserNotFound(e.Message);
            }
            catch (ProductNotFoundException e)
            {
                Ui.DisplayProductNotFound(e.Message);
            }
            catch (InsufficientFundsException e)
            {
                Ui.DisplayInsufficientCash(e.Message);
            }

            if (success == true)
            {
                Ui.DisplayUserBuysProduct(transactions);
            }
        }


        private void ParseAdminCommands(string command)
        {
            string[] split = command.Split(' ');
            string adminCommand = split[0];
            Regex productIDMatch = new Regex("[:a-zæøåA-ZÆØÅ]+[\\s][\\d]+"); //Tjekker efter en command efterfulgt af et space og et tal
            Regex addCreditsMatch = new Regex("[:a-zæøåA-ZÆØÅ]+[\\s][\\a-zæøåA-ZÆØÅ]+[\\s][\\d]+"); //Tjekker efter en command efterfulgt af brugernavn og et tal
            Regex quitMatch = new Regex("^[\\a-zæøåA-ZÆØÅ$]+"); //[[\a-zæøåA-ZÆØÅ]]+ Tjekker efter at der kun er en string
            int productID = -1;
            string userName = null;
            int creditsToAdd = -1;

            if (productIDMatch.IsMatch(command))
            {
                productID = Convert.ToInt32(split[1]);
            } 
            else if (addCreditsMatch.IsMatch(command))
            {
                userName = split[1];
                creditsToAdd = Convert.ToInt32(split[2]);
            } 
            else if (quitMatch.IsMatch(command))
            {
               
            }
            else
            {
                throw new InvalidInputException($"The admin command : {command} doesnt exists");
            }

            Dictionary<string, Action> adminCommands = new Dictionary<string, Action>()
            {
                { ":quit", () => Ui.Close() },
                { ":q", () => Ui.Close() },
                { ":activate", () => Core.GetProductByID(productID).IsActive=true},
                { ":deactivate", () => Core.GetProductByID(productID).IsActive=false},
                { ":crediton", () => Core.GetProductByID(productID).CanBeBoughtOnCredit=true},
                { ":creditoff", () => Core.GetProductByID(productID).CanBeBoughtOnCredit=false},
                { ":addcredits", () => Core.AddCreditsToAccount(Core.GetUserByUsername(userName), creditsToAdd)}
            };

            adminCommands[adminCommand]();
        }
    }
}
