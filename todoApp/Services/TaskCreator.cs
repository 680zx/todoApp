using System;
using Entities;
using Services.Interfaces;

namespace Services
{
    public class TaskCreator : ICreator
    {
        public UserTask Create(string taskName, string taskDescription, DateTime taskTime)
        {
            if (taskName == null)
                throw new ArgumentNullException(taskName, "Param [taskName] is null.");

            if (taskDescription == null)
                throw new ArgumentNullException(taskDescription, "Param [taskDescription] is null.");

            if (taskTime < DateTime.Now)
                throw new ArgumentException(taskTime.ToString("G"), "The param [taskTime] is less than the current date time.");

            return new UserTask
            {
                Name = taskName,
                Description = taskDescription,
                NotificationTime = taskTime
            };
        }
    }
}