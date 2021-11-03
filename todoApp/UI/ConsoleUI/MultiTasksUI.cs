using Entities;
using System;
using System.Collections.Generic;
using todoApp.Common.Interfaces;
using todoApp.UI.Interfaces;

namespace todoApp.UI.ConsoleUI
{
    public class MultiTasksUI : BaseTaskUI, IMultipleObjectsUI<UserTask>
    {
        public MultiTasksUI(ITextFormatter textFormatter) : base(textFormatter)
        {
        }

        public void Show(IEnumerable<UserTask> tasks)
        {
            foreach (var task in tasks)
            {
                base.Show(task);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
