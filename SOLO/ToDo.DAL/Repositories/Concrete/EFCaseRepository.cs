using System;
using System.Collections.Generic;
using ToDo.BOL.Entity;
using ToDo.DAL.Repositories.Abstract;

namespace ToDo.DAL.Repositories.Concrete
{
    public class EFCaseRepository : ICaseRepository
    {
        private readonly EFContext context = new EFContext();





        public void Create(Case @case)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, Case @case)
        {
            throw new NotImplementedException();
        }

        public Case GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Case> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
