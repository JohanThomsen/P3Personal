using System;

namespace Opgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Sequence seq = new Sequence(1, 2, 4);
            foreach (int input in seq)
            {
                Console.WriteLine(input);
            }

            RandomNNumbers rands = new RandomNNumbers(5, 100, 5, 10);

            foreach (int number in rands)
            {
                Console.WriteLine(number);
            }

            SortedList<Person> people = new SortedList<Person>();
            people.Add(new Person("John"));
            people.Add(new Person("Simon"));
            people.Add(new Person("Adam"));
            people.Add(new Person("Sarah"));
            people.Add(new Person("Åge"));
            people.Add(new Person("Johan"));

            foreach (Person dude in people)
            {
                Console.WriteLine(dude.Name);
            }
            Console.WriteLine("_______________________________________________________________________________________");
            foreach (Person dude in people.GetElementsReversed())
            {
                Console.WriteLine(dude.Name);
            }
            Console.WriteLine("_______________________________________________________________________________________");
            foreach (Person dude in people.GetElements(d => d.Name.Contains("a") == true))
            {
                Console.WriteLine(dude.Name);
            }

        }
    }
}
