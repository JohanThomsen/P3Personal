using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;

namespace MenuProject 
{
    public class FileSystemMenu : Menu, IMenu
    {
        private DirectoryInfo _di;
        private DirectoryInfo[] dirs;
        private FileInfo[] files;
        private bool initiated = false;
        public FileSystemMenu(string drive, DirectoryInfo di) :
           base(drive)
        {
            _di = di;
            try
            {
                dirs = _di.GetDirectories();
                files = _di.GetFiles();
            }
            catch (Exception)
            {
                
            }
        }


        public override void Select()
        {
            if (initiated == false)
            {
                
                for (int i = 0; i < dirs.Length; i++)
                {
                    _items.Add(new FileSystemMenu(dirs[i].FullName, new DirectoryInfo(dirs[i].FullName)));
                }
                for (int i = 0; i < files.Length; i++)
                {
                    _items.Add(new MenuItem(files[i].FullName, "This is a file, not a directory please go back <3"));
                }
                initiated = true;
            }
            
            Start();
        }
        protected override void Draw()
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Title.Length / 2)) + "}", Title));
            for (int i = 0; i < _menuLength; i++)
            {
                if (i == 0)           Console.WriteLine("__________________Directories___________________");
                if (i == dirs.Length) Console.WriteLine("_____________________Files______________________");
                if (i == _selected)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    PrintRelevantType(_items[i]);
                    Console.ResetColor();
                }
                else
                {
                    PrintRelevantType(_items[i]);
                }
            }
        }
    }
}
