using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todoApp.UI.Interfaces;

namespace todoApp.UI
{
    class ConsoleUserInterface : IUserInterface
    {
        public void ShowAllTasks(IEnumerable<UserTask> userTasks)
        {
            throw new NotImplementedException();
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("");
        }

        public void ShowTask(UserTask task)
        {
            throw new NotImplementedException();
        }
    }
}
