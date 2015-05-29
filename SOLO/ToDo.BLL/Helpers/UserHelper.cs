using Ninject;
using ToDo.BLL.Infrastracture;
using ToDo.BOL.Entity;
using ToDo.DAL.Abstract;

namespace ToDo.BLL.Helpers
{
    public class UserHelper
    {
        private readonly IUserRepository repository;

        public UserHelper()
        {
            IKernel kernel = new StandardKernel(new Bindings());
            repository = kernel.Get<IUserRepository>();
        }
        public void CreateUser(User u)
        {
            repository.Create(u);
        }

        public void EditUser(int id)
        {
            repository.Edit(id);
        }

        public void DeleteUser(int id)
        {
            repository.Delete(id);
        }

        public void GetUserById(int id)
        {
            repository.GetById(id);
        }

        public void GetAllUsers()
        {
            repository.GetAll();
        }
    }
}
