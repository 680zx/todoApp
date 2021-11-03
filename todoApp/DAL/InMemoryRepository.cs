using Entities;
using System.Collections.Generic;
using System.Linq;
using todoApp.DAL.Interfaces;

namespace todoApp.DAL
{
    class InMemoryRepository : IRepository
    {
        private List<UserTask> _userTasks = new();

        public void Add(UserTask task)
        {
            _userTasks.Add(task);
        }

        public void Delete(int id)
        {
            _userTasks.RemoveAt(id);
        }

        public IEnumerable<UserTask> GetAll()
        {
            return _userTasks;
        }

        public UserTask GetById(int id)
        {
            return _userTasks.Where(i => i.Id == id).FirstOrDefault();
        }

        public void Update(UserTask task)
        {
            var id = task.Id;
            _userTasks[id] = task;
        }
    }
}
