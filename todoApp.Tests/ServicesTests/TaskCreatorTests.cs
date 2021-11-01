using System;
using NUnit.Framework;
using Services;
using Services.Interfaces;

namespace ServicesTests
{
    [TestFixture]
    public class TaskCreatorTests
    {
        [Test]
        public void Create_CorrectValues_CorrectTaskReturned()
        {
            // Arrange
            const string TASK_NAME = "TestTask";
            const string TASK_DESCRIPTION = "Test Description";

            var nextYear = DateTime.Now.Year + 1;
            DateTime taskNotificationTime = new(nextYear, 01, 01, 00, 00, 00);
            ICreator taskCreator = new TaskCreator(); 

            // Act
            var result = taskCreator.Create(TASK_NAME, TASK_DESCRIPTION, taskNotificationTime);

            // Assert
            Assert.AreEqual(result.Name, TASK_NAME);
            Assert.AreEqual(result.Description, TASK_DESCRIPTION);
            Assert.AreEqual(result.NotificationTime, taskNotificationTime);
        }

        [Test]
        public void Create_NameIsNull_ExceptionThrown()
        {
            // Arrange
            string TASK_NAME = null;
            const string TASK_DESCRIPTION = "Test Description";

            var nextYear = DateTime.Now.Year + 1;
            DateTime taskNotificationTime = new(nextYear, 01, 01, 00, 00, 00);
            ICreator taskCreator = new TaskCreator();

            // Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                taskCreator.Create(TASK_NAME, TASK_DESCRIPTION, taskNotificationTime);
            });          
        }

        [Test]
        public void Create_DescIsNull_ExceptionThrown()
        {
            // Arrange
            string TASK_NAME = "";
            const string TASK_DESCRIPTION = null;

            var nextYear = DateTime.Now.Year + 1;
            DateTime taskNotificationTime = new(nextYear, 01, 01, 00, 00, 00);
            ICreator taskCreator = new TaskCreator();

            // Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                taskCreator.Create(TASK_NAME, TASK_DESCRIPTION, taskNotificationTime);
            });
        }

        [Test]
        public void Create_NotificationTimeLessThanCurrentOne_ExceptionThrown()
        {
            // Arrange
            string TASK_NAME = "";
            const string TASK_DESCRIPTION = "";
            DateTime taskNotificationTime = new(2020, 01, 01, 00, 00, 00);
            ICreator taskCreator = new TaskCreator();

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                taskCreator.Create(TASK_NAME, TASK_DESCRIPTION, taskNotificationTime);
            });
        }
    }
}