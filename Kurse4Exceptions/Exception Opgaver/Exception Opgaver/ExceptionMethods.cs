using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Opgaver
{
    class ExceptionMethods
    {
        public int ReadInteger()
        {
            Console.WriteLine("Enter an integer");
            int integer = 0;
            try
            {
                integer = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You must input an integer");
                ReadInteger();
            }

            return integer;
        }
    }
}
