using System;
using NUnit.Framework;
using Entities;
using Moq;

namespace DALTests
{
    [TestFixture]
    class RepositoryTests
    {
        private Task _task;

        [SetUp]
        public void Init()
        {
            var nextYear = DateTime.Now.Year + 1;
            _task = new Task
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
            

            //
        }
    }
}