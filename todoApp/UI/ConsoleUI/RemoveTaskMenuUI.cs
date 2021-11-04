using System;
using todoApp.UI.Interfaces;

namespace todoApp.UI.ConsoleUI
{
    public class RemoveTaskMenuUI : IUserInterface
    {
        public void Show()
        {
            Console.Write("Task ID: ");
        }
    }
}
