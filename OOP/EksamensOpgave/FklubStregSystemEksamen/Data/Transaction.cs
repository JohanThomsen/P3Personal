using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FklubStregSystemEksamen.Data
{
    abstract class Transaction : IEnumerable<Transaction>
    {
        static int internalID = 0;
        private int IncrementID()
        {
            return internalID++;
        }

        List<Transaction> internalList = new List<Transaction>();
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

        public Transaction this[int index]
        {
            get { return internalList[index]; }
            set { internalList.Insert(index, value); }
        }

        public IEnumerator<Transaction> GetEnumerator()
        {
            return internalList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public abstract void Execute();
    }
}
