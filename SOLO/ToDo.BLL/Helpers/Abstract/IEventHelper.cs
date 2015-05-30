using System.Collections.Generic;
using ToDo.BOL.Entity;

namespace ToDo.BLL.Helpers.Abstract
{
    interface IEventHelper : IEntityHelper
    {
        void Create(Event @event);

        void Edit(int id, Event @event);

        Event GetById(int id);

        IEnumerable<Event> GetAll();
    }
}