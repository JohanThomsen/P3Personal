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
            IStregsystem stregsystem = new Stregsystem();
            IStregsystemUI ui = new StregsystemUI(stregsystem);
            StregSystemController sc = new StregSystemController(ui, stregsystem);

            ui.Start();

            /*sc.ParseCommand("jleve");
            sc.ParseCommand("jleve 20");
            sc.ParseCommand("jleve 3 30");

            sc.ParseCommand(":activate 25");

            IEnumerable<Product> activeproducts = stregsystem.ActiveProducts;

            foreach (Product prod in activeproducts)
            {
                Console.WriteLine(prod);
            }*/
        }
    }
}
