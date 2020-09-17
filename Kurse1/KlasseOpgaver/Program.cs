using System;

namespace KlasseOpgaver
{
    class Program
    {
        static int PersonId = 0;
        static void Main(string[] args)
        {
            
            Person Anna = new Person("Anna", "Løhde", 82, PersonId++);
            Person Henning = new Person("Henning", "Thomsen", 90, PersonId++);

            Person Preben  = new Person("Preben", "Thomsen", 62, PersonId++);
            Person Jonna   = new Person("Jonna", "Løhde", 55, PersonId++, Anna, Henning);

            Person Johan   = new Person("Johan", "Thomsen", 22, PersonId++, Jonna, Preben);

            Johan.PrintTree();
        }
    }
}
