using System.Collections.Generic;
using ToDo.BOL.Entity;

namespace ToDo.DAL.Repositories.Abstract
{
    public interface ICaseRepository : IEntityRepository
    {
        void Create(Case @case);

        void Edit(Case @case);

        Case GetById(int id);

        IEnumerable<Case> GetAll();
    }
}
