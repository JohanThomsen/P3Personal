using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MenuProject
{
    class InfiniteMenu : Menu, IMenu
    {
        private bool initiated = false;
        public InfiniteMenu(string Title) :
            base(Title)
        {

        }

        public override void Select()
        {
            Console.Clear();
            if (initiated == false)
            {
                AddMenus();
                initiated = true;
            }
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
