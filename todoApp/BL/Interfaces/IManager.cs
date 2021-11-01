using Entities;
using System.Collections.Generic;

namespace todoApp.BL.Interfaces
{
    public interface IManager
    {
        public void Add(UserTask task);

        public void Update(UserTask task);

        public void Delete(int id);

        public UserTask GetById(int id);

        public IEnumerable<UserTask> GetAll();
    }
}
