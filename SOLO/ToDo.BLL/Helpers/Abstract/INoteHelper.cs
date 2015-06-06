using System.Collections.Generic;
using ToDo.BOL.Entity;

namespace ToDo.BLL.Helpers.Abstract
{
    interface INoteHelper : IEntityHelper
    {
        void Create(Note note);

        void Edit(Note note);

        Note GetById(int id);

        IEnumerable<Note> GetAll();
    }
}