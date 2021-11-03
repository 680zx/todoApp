using System;
using todoApp.UI.Interfaces;

namespace todoApp.UI.ConsoleUI
{
    public class MainMenuUI : IUserInterface
    {
        public void Show()
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Remove Task");
            Console.WriteLine("3. Show");
            Console.WriteLine("4. Quit");
        }
    }
}
