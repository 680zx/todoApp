using Entities;
using System.Collections.Generic;

namespace todoApp.UI.Interfaces
{
    public interface IUserInterface
    {
        public void ShowMainMenu();
        public void ShowTask(UserTask task);
        public void ShowAllTasks(IEnumerable<UserTask> userTasks);
    }
}
