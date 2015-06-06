using System.Collections.Generic;
using ToDo.BOL.Entity;

namespace ToDo.DAL.Repositories.Abstract
{
    public interface IUserRepository : IEntityRepository
    {
        void Create(User user);

        void Edit(User user);
        
        User GetById(int id);

        IEnumerable<User> GetAll();
    }
}
