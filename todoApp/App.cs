using Entities;
using todoApp.Common;
using todoApp.Common.Interfaces;
using todoApp.UI;
using todoApp.UI.Interfaces;

namespace todoApp
{
    public class App
    {
        private static IUserInterface _userInterface;

        public static void Main(string[] args)
        {
            Init();

            var task = new UserTask
            {
                Id = 1,
                Name = "Create App",
                NotificationTime = new System.DateTime(2022, 01, 01, 0, 0, 0),
                Description = "Разработать приложение, позволяющее управлять задачами, " +
                "то есть, добавлять, удалять и просматривать их. Редактирование задач также " +
                "необходимо реализовать, но перед этим стоит немного поправить ТЗ, хотя это " +
                "и нежелательно делать на текущем этапе разработки."
            };

            _userInterface.ShowTask(task);
        }

        private static void Init()
        {
            ITextFormatter textFormatter = new TextFormatter(64);
            _userInterface = new ConsoleUserInterface(textFormatter);
        }
    }
}