using System;

namespace KlasseOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Johan = new Person("Johan", "Thomsen", 22, new Person("Jonna", "Løhde", 55), new Person("Preben", "Thomsen", 62));

            Johan.PrintCheck();
        }
    }
}
