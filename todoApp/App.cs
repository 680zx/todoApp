using Entities;
using Services;
using Services.Interfaces;
using System.Collections.Generic;
using todoApp.BL;
using todoApp.BL.Interfaces;
using todoApp.Common;
using todoApp.Common.Interfaces;
using todoApp.DAL;
using todoApp.DAL.Interfaces;
using todoApp.UI;
using todoApp.UI.Interfaces;

namespace todoApp
{
    public class App
    {
        #region settings

        private const int MAX_TASK_DESCRIPTION_WIDTH = 64;

        #endregion

        private static App _app = new App();
        private IUserInterface userInterface;
        private IRepository repository;
        private IManager manager;
        private ICreator taskCreator;
        private IUserInputReader userInputReader;

        private void Init()
        {
            ITextFormatter textFormatter = new TextFormatter(MAX_TASK_DESCRIPTION_WIDTH);
            _app.userInterface = new ConsoleUserInterface(textFormatter);
            _app.repository = new InMemoryRepository();
            _app.manager = new Manager(repository);
            _app.taskCreator = new TaskCreator();
            _app.userInputReader = new ConsoleUserReader();
        }

        public static void Main(string[] args)
        {            
            _app.Init();

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

            var task2 = new UserTask
            {
                Id = 2,
                Name = "Update App",
                NotificationTime = new System.DateTime(2022, 01, 01, 0, 0, 0),
                Description = "Переработать приложение, изменив консольный интерфейс на веб " +
                "страницу. Пока, правда, непонятно, как это реализовать..."
            };

            var task3 = new UserTask
            {
                Id = 3,
                Name = "Publish App",
                NotificationTime = new System.DateTime(2023, 01, 01, 0, 0, 0),
                Description = "Выложить приложение на гитхаб или гитлаб."
            };

            List<UserTask> tasksList = new List<UserTask>
            {
                task,
                task2,
                task3
            };

            _app.userInterface.ShowTask(task);
            _app.userInterface.ShowAllTasks(tasksList);
        }
    }
}