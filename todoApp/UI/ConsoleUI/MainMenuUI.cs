using System;
using todoApp.UI.Interfaces;

namespace todoApp.UI.ConsoleUI
{
    public class MainMenuUI : IUserInterface
    {
        public void Show()
        {
            Console.Clear();
            
            Console.WriteLine("\n\t1. Add Task");
            Console.WriteLine("\t2. Remove Task");
            Console.WriteLine("\t3. Show");
            Console.WriteLine("\t4. Show All");
            Console.WriteLine("\t5. Quit");
        }
    }
}
