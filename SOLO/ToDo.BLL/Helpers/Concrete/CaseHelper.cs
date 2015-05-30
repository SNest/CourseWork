using System.Collections.Generic;
using Ninject;
using ToDo.BLL.Helpers.Abstract;
using ToDo.BLL.Infrastracture;
using ToDo.BOL.Entity;
using ToDo.DAL.Repositories.Abstract;

namespace ToDo.BLL.Helpers.Concrete
{
     public class CaseHelper : ICaseHelper
    {
        private readonly ICaseRepository repository;

        public CaseHelper()
        {
            IKernel kernel = new StandardKernel(new Bindings());
            repository = kernel.Get<ICaseRepository>();
        }
        public void Create(Case @case)
        {
            repository.Create(@case);
        }

        public void Edit(int id, Case @case)
        {
            repository.Edit(id, @case);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public Case GetById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Case> GetAll()
        {
            return repository.GetAll();
        }
    }
}