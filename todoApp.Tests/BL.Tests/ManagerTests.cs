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
        public void Add_TaskObject_TaskAdded()
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

        [Test]
        public void Update_TaskObject_TaskUpdated()
        {
            // Arrange
            var repositoryMock = new Mock<IRepository>();
            var _manager = new Manager(repositoryMock.Object);

            // Act
            _manager.Update(_task);

            // Assert
            repositoryMock.Verify(i => i.Update(It.IsAny<UserTask>()),
                                Times.Once);
        }

        [Test]
        public void Delete_IntValue_TaskDeleted()
        {
            // Arrange
            var repositoryMock = new Mock<IRepository>();
            var _manager = new Manager(repositoryMock.Object);
            const int TARGET_ID = 0;

            // Act
            _manager.Delete(TARGET_ID);

            // Assert
            repositoryMock.Verify(i => i.Delete(It.IsAny<int>()),
                                Times.Once);
        }

        [Test]
        public void GetById_IntValue_TaskReturned()
        {
            // Arrange
            var repositoryMock = new Mock<IRepository>();
            var _manager = new Manager(repositoryMock.Object);
            const int TARGET_ID = 0;

            // Act
            _manager.GetById(TARGET_ID);

            // Assert
            repositoryMock.Verify(i => i.GetById(It.IsAny<int>()),
                                Times.Once);
        }

        [Test]
        public void GetAll_NoInputValues_TaskListReturned()
        {
            // Arrange
            var repositoryMock = new Mock<IRepository>();
            var _manager = new Manager(repositoryMock.Object);

            // Act
            _manager.GetAll();

            // Assert
            repositoryMock.Verify(i => i.GetAll(),
                                Times.Once);
        }
    }
}