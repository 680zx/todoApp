using System;
using Entities;

namespace Services.Interfaces
{
    public interface ICreator
    {
        public UserTask Create(int id, string name, string description, DateTime time);
    }
}
