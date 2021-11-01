using System;
using NUnit.Framework;
using Entities;
using Moq;
using todoApp.DAL.Interfaces;
using todoApp.BL.Interfaces;
using todoApp.BL;

namespace BL.Tests
{
    [TestFixture]
    class ManagerTests
    {
        private UserTask _task;
        private IManager _manager;

        [SetUp]
        public void Init()
        {
            var nextYear = DateTime.Now.Year + 1;
            _task = new UserTask
            {
                Name = "testTask",
                Description = "test task",
                NotificationTime = new DateTime(nextYear, 01, 01, 00, 00, 00)
            };
        }

        [Test]
        public void AddTask_TaskObject_TaskAdded()
        {
            // Arrange
            var repositoryMock = new Mock<IRepository>();
            var _manager = new Manager(repositoryMock.Object);

            // Act
            _manager.Add(_task);

            // Assert
            repositoryMock.Verify(i => i.Add(It.IsAny<UserTask>()),
                                Times.Once);
        }
    }
}