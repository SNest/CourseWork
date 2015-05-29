using ToDo.BOL.Entity;
using ToDo.DAL.Abstract;

namespace ToDo.DAL.Concrete
{
    class EFEventRepository : IEntityRepository
    {
        private readonly EFContext context = new EFContext();
        public void Create(Entity e)
        {
            context.Events.Add((Event)e);
            Save();
        }

        public void Edit(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public Case GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Entity> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
