using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata;

namespace BasicOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            int numberI;
            Methods m = new Methods();

            //Console.WriteLine(m.RadianToDegrees(Math.PI));
            //Console.WriteLine(m.DegreesToRadians(180));

            //m.DotPrinter(5);
            //m.ReverseDotPrinter(5);

            //Console.WriteLine("Input number to get square root");
            //number = m.GetDouble();

            //Console.WriteLine(m.SquareRoot(number));

            Console.WriteLine("How many members are in your group ?");
            numberI = m.GetInt();
            m.Group(numberI);
                
        }

    }

    class Methods
    {
        public double RadianToDegrees(double radian)
        {
            return radian * (180 / Math.PI);
        }

        public double DegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        public void DotPrinter(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void ReverseDotPrinter(int rows)
        {
            for (int i = rows; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public double GetDouble()
        {
            if (Double.TryParse(Console.ReadLine(), out double number))
            {
                Console.WriteLine(number);
                return number;
            }
            else
            {
                Console.WriteLine("Unable to parse input, please input a double");
                return GetDouble();
            }
        }

        public int GetInt()
        {
            if (Int32.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine(number);
                return number;
            }
            else
            {
                Console.WriteLine("Unable to parse input, please input an int");
                return GetInt();
            }
        }
        public double SquareRoot(double number)
        {
            return Math.Sqrt(number);
        }

        public void Group(int members)
        {
            List<string> memberList = new List<string>();
            Console.WriteLine($"Your group has {members} members");

            for (int i = 1; i <= members; i++)
            {
                Console.WriteLine($"What is the name of member {i}");
                memberList.Add(Console.ReadLine());
            }
            string[] memberArray = memberList.ToArray();

            for (int i = 0; i < memberArray.Length; i++)
            {
                Console.WriteLine(memberArray[i]);
            }
        }
        public void NoPromptGroup()
        {
            List<string> memberList = new List<string>();

        }
    }
}
