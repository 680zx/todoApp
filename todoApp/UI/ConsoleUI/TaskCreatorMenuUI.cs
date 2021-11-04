using System;

namespace todoApp.UI.ConsoleUI
{
    public class TaskCreatorMenuUI    
    {
        public void ShowTaskNameInput(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write("Task Name: ");
        }

        public void ShowDateInput(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write("Date: ");
        }

        public void ShowDescriptionInput(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write("Description:");
            Console.WriteLine();
        }
    }
}
