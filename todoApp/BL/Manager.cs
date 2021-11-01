using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserTask> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserTask GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserTask task)
        {
            throw new NotImplementedException();
        }
    }
}
