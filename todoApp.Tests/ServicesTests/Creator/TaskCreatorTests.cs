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
            DateTime taskCreationTime = new DateTime(2021, 01, 01, 00, 00, 00);
            ICreator taskCreator = new TaskCreator(); 

            // Act
            var result = taskCreator.Create(TASK_NAME, TASK_DESCRIPTION, taskCreationTime);

            // Assert
            Assert.AreEqual(result.Name, TASK_NAME);
            Assert.AreEqual(result.Description, TASK_DESCRIPTION);
            Assert.AreEqual(result.CreationTime, taskCreationTime);
        }
    }
}