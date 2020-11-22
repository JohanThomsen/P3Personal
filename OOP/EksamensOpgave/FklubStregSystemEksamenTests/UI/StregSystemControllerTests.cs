using Microsoft.VisualStudio.TestTools.UnitTesting;
using FklubStregSystemEksamen.UI;
using FklubStregSystemEksamen.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FklubStregSystemEksamen.UI.Tests
{
    [TestClass()]
    public class StregSystemControllerTests
    {

        [TestMethod()]
        public void ParseCommandTest()
        {
            Stregsystem core = new Stregsystem(new DatabaseAccess());
            StregSystemController controller = new StregSystemController(new StregsystemUI(core), core);

            
        }
    }
}