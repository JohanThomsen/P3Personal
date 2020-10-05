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
    private bool _running = true;

    public void Select()
    {
        _running = true;
        do
        {
            Console.WriteLine(Content);
            AwaitInput();
        } while (_running);
   
        
    }

    private void AwaitInput()
    {
        ConsoleKeyInfo cki = Console.ReadKey();
        if (cki.Key == ConsoleKey.Escape || cki.Key == ConsoleKey.Backspace)
        {
            Console.Clear();
            _running = false;
        }
        else
        {
            Console.Clear(); 
        }
    }
}
