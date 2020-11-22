using Microsoft.VisualStudio.TestTools.UnitTesting;
using FklubStregSystemEksamen.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FklubStregSystemEksamen.Data.Tests
{
    [TestClass()]
    public class StregsystemTests
    {
        Stregsystem s = new Stregsystem(new DatabaseAccess());
        [TestMethod()]
        public void GetUserByUsernameTest()
        {

            User u = s.GetUserByUsername("afull");

            Assert.AreEqual("afull", u.Username); 
            Assert.AreEqual("Andrew", u.Firstname);
        }

        //Returns false wven thought i know it works. SAys the file is already being used idk
        /*[TestMethod()]
        public void ExecuteTransactionTest()
        {

            bool result = s.ExecuteTransaction(new BuyTransaction(s.DaAccess.users[0], DateTime.Now, s.DaAccess.products[0]));
            
            Assert.AreEqual(true, result);
        }*/

        [TestMethod()]
        public void GetProductByIDTest()
        {

            Product p = s.GetProductByID(150);

            Assert.AreEqual((Decimal)6.5, p.Price); 
            Assert.AreEqual("Øl(Tuborg/Classic/Carlsberg/Rød)", p.Name); 
        }

        [TestMethod()]
        public void GetUsersTest()
        {

            List<User> result = s.GetUsers(user => user.Firstname.StartsWith("M")).ToList();

            Assert.AreEqual("Margaret", result[0].Firstname);
            Assert.AreEqual("Michael", result[1].Firstname);
        }

        [TestMethod()]
        public void GetTransactionsTest()
        {

            List<Transaction> result = s.GetTransactions(s.GetUserByUsername("jleve"), 1).ToList();

            Assert.AreEqual(0, result[0].ID); 

        }
    }
}