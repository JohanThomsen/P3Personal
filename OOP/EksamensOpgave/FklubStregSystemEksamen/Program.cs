using System;
using System.Collections.Generic;
using System.Linq;
using FklubStregSystemEksamen.Data;
using FklubStregSystemEksamen.Exceptions;
using FklubStregSystemEksamen.UI;

namespace FklubStregSystemEksamen
{
    class Program
    {
        static void Main(string[] args)
        {            
            IStregsystem stregsystem = new Stregsystem(new DatabaseAccess());
            IStregsystemUI ui = new StregsystemUI(stregsystem);
            StregSystemController sc = new StregSystemController(ui, stregsystem);

            sc.ParseCommand("jleve 15");
                
            
        }
    }
}
