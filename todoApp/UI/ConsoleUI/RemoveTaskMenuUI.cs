using System;
using todoApp.UI.Interfaces;

namespace todoApp.UI.ConsoleUI
{
    public class RemoveTaskMenuUI : IUserInterface
    {
        public void Show()
        {
            Console.SetCursorPosition(20, 4);
            Console.Write("Task ID: ");
        }
    }
}
