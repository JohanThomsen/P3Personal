using System;
using System.Collections.Generic;

namespace DelegatesOpgaver
{
    
    class Program
    {

        static void Main(string[] args)
        {
            Methods m = new Methods();

            //StringJoin join = (l, r) => { return l + r; };
            //string combined = join("Hello ", "Delegates");
            //Console.WriteLine("First combine" + combined);

            //string secondCombineNormal = m.JoinThree("a", "b", "c", (l, r) => l + r);
            //Console.WriteLine(secondCombineNormal);
            //string secondCombineDot = m.JoinThree("a", "b", "c", (l, r) => l + "." + r);
            //Console.WriteLine(secondCombineDot);

            //string joinAllCombine = m.JoinAllStrings(new List<string> { "a", "b", "c", "d" }, (l, r) => l + r);
            //Console.WriteLine(joinAllCombine);
            //string joinAllCombineDot = m.JoinAllStrings(new List<string> { "a", "b", "c", "d" }, (l, r) => l + "." + r);
            //Console.WriteLine(joinAllCombineDot);

            //Console.WriteLine(m.JoinAll(new List<int> { 1, 2, 3, 4 }, (a, b) => a + b));
            //Console.WriteLine(m.JoinAll(new List<int> { 1, 2, 3, 4 }, (a, b) => a * b));
            //Console.WriteLine(m.JoinAll(new List<string> { "a", "b", "c", "d" }, (l, r) => l + "." + r));

            //bool checkFalse = m.Exists((item) => item == 2, new int[] { 1, 3, 5, 7, 9 });
            //bool checkTrue = m.Exists((item) => item == 2, new int[] { 1, 2, 5, 7, 9 });
            //Console.WriteLine($"Should be false {checkFalse}");
            //Console.WriteLine($"Should be true {checkTrue}");
            //checkTrue = m.Exists((item) => item == "Hello", new string[] { "Hello", "good" });
            //checkFalse = m.Exists((item) => item == "Hello", new string[] { "No", "good" });
            //Console.WriteLine($"Should be false {checkFalse}");
            //Console.WriteLine($"Should be true {checkTrue}");
        }
    }
}
