using System;
using System.Collections.Generic;

namespace InheritanceOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car("Skoda", "Fabia", 50000),
                new Car("Skoda", "Octavia", 60000),
                new Car("skrald", "bil", 10000),
                new Car("Ferrai", "Senna", 200000)
            };

            cars.Sort(new MakeModelPriceComparer());

            foreach (Car Car in cars)
            {
                Console.WriteLine($"{Car.Make} {Car.Model} {Car.Price}");
            }

            List<ITaxable> taxableThings = new List<ITaxable>()
            {
                new Bus(80, 245, 80000),
                new House("Aablorg", true, 150.5, 203829)
            };

            foreach (ITaxable item in taxableThings)
            {
                if (item is Bus)
                {
                    Console.WriteLine(((Bus)item).value);
                    Console.WriteLine($"{item is ITaxable}");
                }
                if (item is House)
                {
                    Console.WriteLine(((House)item).location);
                    Console.WriteLine($"{item is ITaxable}");
                }
            }
        }
    }
}
