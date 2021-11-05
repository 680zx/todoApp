using System;
using todoApp.UI.Interfaces;

namespace todoApp.UI.ConsoleUI
{
    public class ShowMessageUI : IShowMessageUI
    {
        public void Show(string message)
        {
            Console.SetCursorPosition(35, 1);
            Console.WriteLine("Attention: " + message);
        }
    }
}
