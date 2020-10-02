using MenuProject;
using System;
using System.Collections.Generic;
using System.Text;

public class Menu : IMenu
{
	public Menu(string title)
	{
		Title = title;
	}

    public bool Running = true;
    private int Selected = 0;
    private int _menuLength = 0;
    public string Title { get; }

    private List<IMenu> _items = new List<IMenu>();

	public void Add(IMenu item)
	{
		_items.Add(item);
	}

    public void Start()
    {
        _menuLength = _items.Count;
        do
        {
            Draw();
            HandleInput();
        } while (Running);
    }

	private void Draw()
    {
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Title.Length / 2)) + "}", Title));
        for (int i = 0; i < _menuLength; i++)
        {
            if (i == Selected)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                if (_items[i] is MenuItem)
                {
                    Console.WriteLine(((MenuItem)_items[i]).Title);
                } else
                {
                    Console.WriteLine(((Menu)_items[i]).Title);
                }
 
                Console.ResetColor();
            } else
            {
                if (_items[i] is MenuItem)
                {
                    Console.WriteLine(((MenuItem)_items[i]).Title);
                }
                else
                {
                    Console.WriteLine(((Menu)_items[i]).Title);
                }
            }
        }
    }

    private void HandleInput()
    {
        ConsoleKeyInfo cki = Console.ReadKey();
        switch (cki.Key)
        {
            case ConsoleKey.Backspace:
            case ConsoleKey.Escape:
                Console.Clear();
                Running = false;
                break;
            case ConsoleKey.UpArrow:
                Console.Clear();
                MoveUp();
                break;
            case ConsoleKey.DownArrow:
                Console.Clear();
                MoveDown();
                break;
            case ConsoleKey.Enter:
                Console.Clear();
                _items[Selected].Select();
                break;
            default:
                Draw();
                break;
        }
    }

    private void MoveUp()
    {
        if (Selected == 0)
        {
            Selected = _menuLength - 1;
        }
        else
        {
            Selected--;
        }    
    }

    private void MoveDown()
    {
        if (Selected == _menuLength - 1)
        {
            Selected = 0;
        }
        else
        {
            Selected++;
        }
    }

    public void Select()
    {
        Console.Clear();
        Start();
    }

}

