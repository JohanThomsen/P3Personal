using System;
using System.Collections.Generic;
using System.Text;
using FklubStregSystemEksamen.Data;
using FklubStregSystemEksamen.Exceptions;
namespace FklubStregSystemEksamen.UI
{
       public delegate void StregsystemEvent(string displayEvent);
    public interface IStregsystemUI
    {
        void DisplayUserNotFound(string error);
        void DisplayProductNotFound(string error);
        void DisplayUserInfo(User user);
        void DisplayTooManyArgumentsError(string command);
        void DisplayAdminCommandNotFoundMessage(string adminCommand);
        void DisplayUserBuysProduct(BuyTransaction transaction);
        void DisplayUserBuysProduct(List<BuyTransaction> transaction);
        void Close();
        void DisplayInsufficientCash(string error);
        void DisplayGeneralError(string errorString);
        void Start();
        public event StregsystemEvent CommandEntered;
    }
}