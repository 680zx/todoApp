using Entities;
using Services;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using todoApp.BL;
using todoApp.BL.Interfaces;
using todoApp.Common;
using todoApp.Common.Interfaces;
using todoApp.DAL;
using todoApp.DAL.Interfaces;
using todoApp.UI.ConsoleUi;
using todoApp.UI.ConsoleUI;
using todoApp.UI.EnumsUI;
using todoApp.UI.Interfaces;

namespace todoApp
{
    public class App
    {
        #region const settings

        private const int MAX_TASK_DESCRIPTION_WIDTH = 64;

        #endregion

        private static App _app = new App();
        private IUserInterface mainMenuUI;
        private ISingleObjectUI<UserTask> singleObjectUI;
        private IMultipleObjectsUI<UserTask> multipleObjectsUI;
        private IShowMessageUI showMessageUI;
        private IRepository repository;
        private IManager manager;
        private ICreator taskCreator;
        private IUserInputReader userInputReader;
        private AppStatus Status;

        private void Init()
        {
            ITextFormatter textFormatter = new TextFormatter(MAX_TASK_DESCRIPTION_WIDTH);
            _app.mainMenuUI = new MainMenuUI();
            _app.showMessageUI = new ShowMessageUI();
            _app.singleObjectUI = new SingleTaskUI(textFormatter);
            _app.multipleObjectsUI = new MultiTasksUI(textFormatter);
            _app.repository = new InMemoryRepository();
            _app.manager = new Manager(repository);
            _app.taskCreator = new TaskCreator();
            _app.userInputReader = new ConsoleUserReader();
            
        }

        public static void Main(string[] args)
        {
            var isContinue = true;

            #region Test task

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

            #endregion
            _app.repository.Add(task);

            _app.Init();
            _app.DrawMainMenu();

            while (isContinue)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        _app.DrawSingleTaskMenu();
                        break;
                    case ConsoleKey.D4:
                        isContinue = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private string ReadInput() => _app.userInputReader.Read();

        private void DrawMainMenu()
        {
            _app.mainMenuUI.Show();
            _app.Status = AppStatus.MainMenu;
        }

        private void DrawSingleTaskMenu()
        {
            _app.showMessageUI.Show("Enter task id to show: ");
            Int32.TryParse(ReadInput(), out int taskId);
            var task = _app.repository.GetById(taskId);
            _app.singleObjectUI.Show(task);
            _app.Status = AppStatus.ShowSingleTaskMenu;
        }

        private void DrawMultiTasksMenu(IEnumerable<UserTask> tasks)
        {
            _app.multipleObjectsUI.Show(tasks);
            _app.Status = AppStatus.ShowAllTasksMenu;
        }
    }
}

/*  var task = new UserTask
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
         */