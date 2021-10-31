using System;
using Entities;

namespace Services.Interfaces
{
    public interface ICreator
    {
        public Task Create(string name, string description, DateTime time);
    }
}
