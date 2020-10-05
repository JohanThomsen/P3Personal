using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MenuProject
{
    class InfiniteMenu : Menu, IMenu
    {
        public InfiniteMenu(string Title) :
            base(Title)
        {

        }

        public override void Select()
        {
            Console.Clear();
            AddMenus();
            Start();
        }

        private void AddMenus()
        {
            int _menuLength = 6;
            for (int i = 1; i <= _menuLength; i++)
            {
                Add(new InfiniteMenu($"Infinite Menu {i}"));
            }
        }
    }
}
