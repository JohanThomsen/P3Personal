using System;
using FklubStregSystemEksamen.Data;
using FklubStregSystemEksamen.Exceptions;

namespace FklubStregSystemEksamen
{
    class Program
    {
        static void Main(string[] args)
        {
            Database<User> d = new Database<User>();

            d.FillFromDatabaseFile("..\\Data\\users.csv");
        }
    }
}
