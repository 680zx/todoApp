using Entities;
using System.Collections.Generic;
using todoApp.BL.Interfaces;
using todoApp.DAL.Interfaces;

namespace todoApp.BL
{
    public class Manager : IManager
    {
        private readonly IRepository _repository;
            
        public Manager(IRepository repository)
        {
            _repository = repository;
        }

        public void Add(UserTask task)
        {
            _repository.Add(task);
        }

        public void Update(UserTask task)
        {
            _repository.Update(task);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public UserTask GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<UserTask> GetAll()
        {
            return _repository.GetAll();
        }        
    }
}
