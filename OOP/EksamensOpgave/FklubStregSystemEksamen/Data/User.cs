using System;
using System.Collections.Generic;
using System.Text;

namespace FklubStregSystemEksamen.Data
{
    delegate void UserBalanceNotification(User user, decimal balance);
    class User : IComparable, IDatabase
    {
        //Lidt ulovligt. Hvis jeg finder en bedre løsning fikser jeg det.
        static int internalID = 0;
        private int IncrementID()
        {
            return internalID++;
        }
        public User(string firstname, string lastname, string username, string email, int balance)
        {
            ID = IncrementID();
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Email = email;
            Balance = balance;
        }
        public UserBalanceNotification UnderFiftyNotification;
        public int ID { get; set; }

        private string _firstname;
        public string Firstname
        {
            get { return _firstname; }
            set 
            {
                if (value != null) { _firstname = value; } else throw new ArgumentNullException();
            }
        }


        private string _lastname;
        public string Lastname
        {
            get { return _lastname; }
            set 
            {
                if (value != null) { _lastname = value; } else throw new ArgumentNullException();
            }
        }

        private string _username;
        public string Username
        {
            get { return _username; }
            set 
            { 
                //TODO validate
                _username = value; 
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set 
            {
                //TODO Validate
                _email = value; 
            }
        }

        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
            set 
            {
                decimal _balance = value;
                if (_balance >= 50)
                {
                    UnderFiftyNotification?.Invoke(this, _balance);
                }              
            }
        }
        public override string ToString()
        {
            return $"{Firstname} {Lastname} ({Email})";
        }

        public int CompareTo(object other)
        {
            //IDK om det her virker
            return ID.CompareTo(other);
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   ID == user.ID &&
                   _firstname == user._firstname &&
                   _lastname == user._lastname &&
                   _username == user._username &&
                   _email == user._email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID, _firstname, _lastname, _username, _email);
        }
    }
}
