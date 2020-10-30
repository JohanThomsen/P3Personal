using System;

namespace Exception_Opgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ExceptionMethods m = new ExceptionMethods();
            m.ReadInteger();*/

            BankAccount myAcc = new BankAccount(10000);
            myAcc.Deposit(20000);
            myAcc.Withdraw(31000);

            GearBox g = new GearBox();

            g.ChangeGear(6);
            g.ChangeGear(4);
            g.ChangeGear(2);
            g.ChangeGear(-1);
        }

    }
}
