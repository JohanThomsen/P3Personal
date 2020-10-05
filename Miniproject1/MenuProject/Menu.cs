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
    private int _selected = 0;
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
            if (i == _selected)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                PrintRelevantType(_items[i]);
                Console.ResetColor();
            } else
            {
                PrintRelevantType(_items[i]);
            }
        }
    }

    private void PrintRelevantType(IMenu Item)
    {
        if (Item is MenuItem)
        {
            Console.WriteLine(((MenuItem)Item).Title);
        }
        else
        {
            Console.WriteLine(((Menu)Item).Title);
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
                _items[_selected].Select();
                break;
            default:
                Draw();
                break;
        }
    }

    private void MoveUp()
    {
        if (_selected == 0)
        {
            _selected = _menuLength - 1;
        }
        else
        {
            _selected--;
        }    
    }

    private void MoveDown()
    {
        if (_selected == _menuLength - 1)
        {
            _selected = 0;
        }
        else
        {
            _selected++;
        }
    }

    public virtual void Select()
    {
        Console.Clear();
        Start();
    }

}

