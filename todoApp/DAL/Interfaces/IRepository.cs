using Entities;
using System.Collections.Generic;

namespace todoApp.DAL.Interfaces
{
    public interface IRepository
    {
        public void Add(UserTask task);

        public void Update(UserTask task);

        public void Delete(int id);

        public UserTask GetById(int id);
    }
}
