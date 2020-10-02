using System;

namespace MenuProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu("First");
            m.Add(new MenuItem("First point", "First Content"));
            m.Add(new MenuItem("Second point", "Second Content"));
            m.Add(new MenuItem("Third point", "Third Content"));
            m.Add(new MenuItem("Fourth point", "Fourth Content"));
            Menu sub = new Menu("SubMenu");
            sub.Add(new MenuItem("First Sub", "First sub content"));
            sub.Add(new MenuItem("Second Sub", "Second sub content"));
            m.Add(sub);
            m.Start();
        }

        

    }
}
