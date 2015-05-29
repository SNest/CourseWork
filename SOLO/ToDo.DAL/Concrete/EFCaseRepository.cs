using ToDo.BOL.Entity;
using ToDo.DAL.Abstract;

namespace ToDo.DAL.Concrete
{
    public class EFCaseRepository : ICaseRepository
    {
        private readonly EFContext context = new EFContext();

        public void Create(Entity e)
        {
            context.Cases.Add((Case)e);
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
            context.SaveChanges();
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
