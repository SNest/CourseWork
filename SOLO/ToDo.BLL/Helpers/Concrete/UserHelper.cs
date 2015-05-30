using System.Collections.Generic;
using Ninject;
using ToDo.BLL.Helpers.Abstract;
using ToDo.BLL.Infrastracture;
using ToDo.BOL.Entity;
using ToDo.DAL.Repositories.Abstract;

namespace ToDo.BLL.Helpers.Concrete
{
    public class UserHelper : IEntityHelper
    {
        private readonly IUserRepository repository;

        public UserHelper()
        {
            IKernel kernel = new StandardKernel(new Bindings());
            repository = kernel.Get<IUserRepository>();
        }
        public void Create(User user)
        {
            repository.Create(user);
        }

        public void Edit(int id, User user)
        {
            repository.Edit(id, user);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public User GetById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<User> GetAll()
        {
            return repository.GetAll();
        }
    }
}
