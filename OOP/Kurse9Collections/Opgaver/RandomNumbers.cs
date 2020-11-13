using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Opgaver
{
    class RandomNNumbers : IEnumerable<int>
    {
        List<int> numbers = new List<int>();

        public int Seed { get; set; }
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public int Amount { get; set; }

        public RandomNNumbers(int seed, int maxValue, int minValue, int amount)
        {
            Seed = seed;
            MaxValue = maxValue;
            MinValue = minValue;
            Amount = amount;
            GenerateRandomNumbers();
        }

       private void GenerateRandomNumbers()
        {
            Random randOBJ = new Random(Seed);
            for (int i = 0; i < Amount; i++)
            {
                numbers.Add(randOBJ.Next(MinValue, MaxValue));
            }
        }

        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers.Insert(index, value); }
        }
        public IEnumerator<int> GetEnumerator()
        {
            return numbers.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
