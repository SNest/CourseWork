using System.Collections.Generic;
using ToDo.BOL.Entity;

namespace ToDo.BLL.Helpers.Abstract
{
    interface ICaseHelper : IEntityHelper
    {
        void Create(Case @case);

        void Edit(int id, Case @case);

        Case GetById(int id);

        IEnumerable<Case> GetAll();
    }
}