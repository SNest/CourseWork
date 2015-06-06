using System.Collections.Generic;
using ToDo.BOL.Entity;

namespace ToDo.DAL.Repositories.Abstract
{
    public interface INoteRepository : IEntityRepository
    {
        void Create(Note note);

        void Edit(Note note);

        Note GetById(int id);

        IEnumerable<Note> GetAll();
    }
}
