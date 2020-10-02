using MenuProject;
using System;
using System.Collections.Generic;
using System.Text;

public class MenuItem : IMenu
{
    public MenuItem(string title, string content)
    {
        Title = title;
        Content = content;
    }
    public string Title { get;}

    public string Content { get;}

    public void Select()
    {
        Console.WriteLine(Content);

        AwaitInput();
    }

    private void AwaitInput()
    {
        ConsoleKeyInfo cki = Console.ReadKey();
        if (cki.Key == ConsoleKey.Escape || cki.Key == ConsoleKey.Backspace)
        {
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Select();
        }
    }
}
