using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FklubStregSystemEksamen.Data
{
    public delegate void UserBalanceNotification(User user, decimal balance);
    public class User : IComparable, IDatabase
    {
        public User(int id, string firstname, string lastname, string username, string email, decimal balance)
        {
            ID = id;
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
                Regex regex = new Regex("^[a-zæøåA-ZÆØÅ_]+");
                if ((regex.IsMatch(value) == true) && !(string.IsNullOrEmpty(value)))
                {
                    _username = value;
                }
                else
                {
                    throw new ArgumentException($"Invalid username: {value}");
                }
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set 
            {
                Regex regex = new Regex("[a-zA-Z0-9.-_]+@[^.-][a-zA-Z0-9.-_]+[.]+[a-zA-Z0-9]+");
                if ((regex.IsMatch(value) == true) && !(string.IsNullOrEmpty(value)))
                {
                    _email = value;
                } else
                {
                    throw new ArgumentException($"Invalid Email {value}");
                }
            }
        }

        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
            set 
            {
                _balance = value;
                if (_balance <= 50)
                {
                }              
            }
        }
        public override string ToString()
        {
            return $"First Name : {Firstname} | Last Name : {Lastname} | UserName : {Username} | Email: {Email} | Balance: {Balance}";
        }

        public int CompareTo(object other)
        {
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
