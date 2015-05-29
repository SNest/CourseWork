using System.Collections.Generic;
using ToDo.BOL.Entity;

namespace ToDo.DAL.Abstract
{
    public interface IEntityRepository
    {
        void Create(Entity e);

        void Edit(int id);

        void Delete(int id);

        void Save();

        Case GetById(int id);

        IEnumerable<Entity> GetAll();
    }
}
