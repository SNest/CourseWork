using System.Collections.Generic;
using Ninject;
using ToDo.BLL.Helpers.Abstract;
using ToDo.BLL.Infrastracture;
using ToDo.BOL.Entity;
using ToDo.DAL.Repositories.Abstract;

namespace ToDo.BLL.Helpers.Concrete
{
    public class EventHelper : IEventHelper
    {
        private readonly IEventRepository repository;

        public EventHelper()
        {
            IKernel kernel = new StandardKernel(new Bindings());
            repository = kernel.Get<IEventRepository>();
        }
        public void Create(Event @event)
        {
            repository.Create(@event);
        }

        public void Edit(int id, Event @event)
        {
            repository.Edit(id, @event);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public Event GetById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Event> GetAll()
        {
            return repository.GetAll();
        }
    }
}
