using System;
using System.Collections.Generic;
using ToDo.BOL.Entity;
using ToDo.DAL.Repositories.Abstract;

namespace ToDo.DAL.Repositories.Concrete
{
    public class EFEventRepository : IEventRepository
    {
        private readonly EFContext context = new EFContext();



        public void Create(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Entity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Create(Event entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Event entity)
        {
            throw new NotImplementedException();
        }

        Event IEventRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Event> IEventRepository.GetAll()
        {
            throw new NotImplementedException();
        }


        public void Edit(int id, Event @event)
        {
            throw new NotImplementedException();
        }
    }
}
