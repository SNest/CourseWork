using System.Collections.Generic;
using ToDo.BOL.Entity;

namespace ToDo.BLL.Helpers.Abstract
{
    interface IUserHelper : IEntityHelper
    {
        void Create(User user);

        void Edit(User user);

        User GetById(int id);

        IEnumerable<User> GetAll();
    }
}
