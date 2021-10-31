using System;
using Entities;
using Services.Interfaces;

namespace Services
{
    public class TaskCreator : ICreator
    {
        public Task Create(string taskName, string taskDescription, DateTime taskTime)
        {
            throw new NotImplementedException();
        }
    }
}