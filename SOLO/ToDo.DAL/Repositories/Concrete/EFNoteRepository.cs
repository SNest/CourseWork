using System;
using System.Collections.Generic;
using ToDo.BOL.Entity;
using ToDo.DAL.Repositories.Abstract;

namespace ToDo.DAL.Repositories.Concrete
{
    public class EFNoteRepository : INoteRepository
    {
        private readonly EFContext context = new EFContext();



        public void Create(Note entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Note entity)
        {
            throw new NotImplementedException();
        }

        public Note GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Note> GetAll()
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


        public void Edit(int id, Note note)
        {
            throw new NotImplementedException();
        }
    }
}
