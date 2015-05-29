using ToDo.BOL.Entity;
using ToDo.DAL.Abstract;

namespace ToDo.DAL.Concrete
{
    class EFUserRepository : IEntityRepository
    {
        private readonly EFContext context = new EFContext();
        public void Create(Entity e)
        {
            context.Users.Add((User)e);
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
