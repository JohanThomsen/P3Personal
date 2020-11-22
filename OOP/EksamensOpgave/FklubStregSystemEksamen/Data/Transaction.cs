using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FklubStregSystemEksamen.Data
{
    public abstract class Transaction : IDatabase
    {
        static int internalID = 0;
        private int IncrementID()
        {
            return internalID++;
        }

        public Transaction(User user, DateTime date)
        {
            ID = IncrementID();
            User = user;
            Date = date;
        }
        public int ID { get; protected set; }
        private User _user;

        public User User
        {
            get { return _user; }
            private set 
            {
                if (value != null) { _user = value; } else throw new ArgumentNullException();             
            }
        }
        public DateTime Date { get; protected set; }

        public decimal Amount { get; protected set; }

        public override string ToString()
        {
            return $"ID: {ID} | User: {User} | Amount: {Amount} | Date: {Date}";
        }

        public virtual string LogToString()
        {
            return $"{User.ID},{User.Firstname},{User.Lastname},{User.Username},{User.Email},{User.Balance},{Date}";
        }

        public abstract bool Execute();
    }
}
