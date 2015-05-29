using ToDo.BOL.Entity;
using ToDo.DAL.Abstract;

namespace ToDo.DAL.Concrete
{
    class EFNoteRepository : IEntityRepository
    {
        private readonly EFContext context = new EFContext();
        public void Create(Entity e)
        {
            context.Notes.Add((Note)e);
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

        public BOL.Entity.Case GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<BOL.Entity.Entity> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
