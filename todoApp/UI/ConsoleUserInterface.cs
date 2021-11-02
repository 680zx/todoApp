using Entities;
using System;
using System.Collections.Generic;
using todoApp.Common.Interfaces;
using todoApp.UI.Interfaces;

namespace todoApp.UI
{
    class ConsoleUserInterface : IUserInterface
    {
        private ITextFormatter _textFormatter;

        public ConsoleUserInterface(ITextFormatter textFormatter)
        {
            _textFormatter = textFormatter;
        }

        public void ShowAllTasks(IEnumerable<UserTask> userTasks)
        {
            foreach (var task in userTasks)
            {
                ShowTask(task);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Remove Task");
            Console.WriteLine("3. Show");
            Console.WriteLine("4. Quit");
        }

        public void ShowTask(UserTask task)
        {
            Console.WriteLine($"{task.Id}. Task: {task.Name}\tDate: {task.NotificationTime:g}");
            Console.WriteLine();
            Console.WriteLine(_textFormatter.Format(task.Description));
        }
    }
}
