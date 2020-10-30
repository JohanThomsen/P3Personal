using System;
using System.Collections.Generic;

namespace GenericsOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            /* HandyMethods m = new HandyMethods();

             int max = m.Max<int>(new List<int> { 2, 15, 4, 6, 8, 10 });
             string min = m.Min<string>(new List<string> { "a", "b", "abc", "g", "o" });

             Console.WriteLine($"Maximum number is {max}, and minimum string is {min}");

             int[] array1 = { 1, 2, 3, 4, 5, 6 };
             int[] array2 = { 7, 8, 9, 10, 11, 12 };

             m.Copy<int>(array1, array2);

             Console.WriteLine("Array 1 after swap");
             foreach (int item in array1)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine("array 2 after swap");
             foreach (int item in array2)
             {
                 Console.WriteLine(item);
             }

             Pair<int, string> p1 = new Pair<int, string>(42, "Hello");

             Console.WriteLine($"Pre swap. Value 1 : {p1.Value1}. value 2 : {p1.Value2}");

             Pair<string, int> p2 = p1.Swap();

             Console.WriteLine($"Post swap. Value 1 : {p2.Value1}. value 2 : {p2.Value2}");

             Pair<bool, int> p3 = p2.SetFst<bool>(true);

             Console.WriteLine($"Post SetFst. Value 1 : {p3.Value1}. value 2 : {p3.Value2}");

             Pair<bool, string> p4 = p3.SetSnd<string>("We in boys");

             Console.WriteLine($"Post SetSnd. Value 1 : {p4.Value1}. value 2 : {p4.Value2}"); */

            Dict<int, string> Dict = new Dict<int, string>();

            Dict.Put(1, "First input");
            Dict.Put(2, "Second input");
            Dict.Put(3, "Third input");
            Dict.Put(4, "Fourth input");
            Dict.Put(5, "Fifth input");
            Dict.Put(1, "First input Changed");

            string output = Dict.Get(1);

            Console.WriteLine(output);
            Console.WriteLine($"{Dict.Get(1)}, {Dict.Get(2)}, {Dict.Get(3)}, {Dict.Get(4)}, {Dict.Get(5)}");

        }
    }
}
