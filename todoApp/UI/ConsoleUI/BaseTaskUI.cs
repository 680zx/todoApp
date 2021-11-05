using Entities;
using System;
using todoApp.Common.Interfaces;

namespace todoApp.UI.ConsoleUI
{
    public abstract class BaseTaskUI
    {
        private ITextFormatter _textFormatter;

        protected BaseTaskUI(ITextFormatter textFormatter)
        {
            _textFormatter = textFormatter;
        }

        protected void Show(UserTask task)
        {
            Console.SetCursorPosition(20, 4);
            Console.WriteLine($"{task.Id}. Task: {task.Name}\tDate: {task.NotificationTime:g}");

            Console.SetCursorPosition(20, 6);
            Console.WriteLine(_textFormatter.Format(task.Description));
        }
    }
}
