using System;
using System.Collections.Generic;
using ToDo.BLL.Helpers.Concrete;
using ToDo.BOL.Entity;

namespace ToDo.SL
{
    public class UserHelperService : IUserHelperService
    {
        private readonly UserHelper uh = new UserHelper();
        public void Create(User user)
        {
            uh.Create(user);
        }

        public void Edit(string id, User user)
        {
            uh.Edit(Convert.ToInt32(id), user);
        }

        public void Delete(string id)
        {
            uh.Delete(Convert.ToInt32(id));
        }

        public User GetById(string id)
        {
            return uh.GetById(Convert.ToInt32(id));;
        }

        public IEnumerable<User> GetAll()
        {
            return uh.GetAll();
        }

        public string XMLData(string id)
        {
            return "Your requested product " + id;
        }
    }
}
