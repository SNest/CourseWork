using System.Collections.Generic;
using ToDo.BOL.Entity;

namespace ToDo.DAL.Repositories.Abstract
{
    public interface IEventRepository : IEntityRepository
    {
        void Create(Event @event);

        void Edit(Event @event);

        Event GetById(int id);

        IEnumerable<Event> GetAll();
    }
}