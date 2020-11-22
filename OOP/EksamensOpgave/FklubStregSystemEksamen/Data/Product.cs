using System;
using System.Collections.Generic;
using System.Text;

namespace FklubStregSystemEksamen.Data
{
    public class Product : IDatabase
    {
        static int internalID = 0;
        private int IncrementID()
        {
            return internalID++;
        }
        public Product(string name, decimal price, int isActive)
        {
            ID = IncrementID();
            Name = name;
            Price = price / 100;
            IsActive = isActive == 0 ? false : true;
        }
        public int ID { get; set; }
        private string _name;

        public string Name
        {
            get { return _name; }
            set 
            {
                if (value != null) { _name = value; } else throw new ArgumentNullException();
            }
        }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }
        public bool CanBeBoughtOnCredit { get; set; }

        public override string ToString()
        {
            return $"ID: {ID} | Name: {Name} | Price: {Price} Kr.";
        }
    }
}
