using System.Collections.Generic;
using Ninject;
using ToDo.BLL.Helpers.Abstract;
using ToDo.BLL.Infrastracture;
using ToDo.BOL.Entity;
using ToDo.DAL.Repositories.Abstract;

namespace ToDo.BLL.Helpers.Concrete
{
    class NoteHelper : INoteHelper
    {
        private readonly INoteRepository repository;

        public NoteHelper()
        {
            IKernel kernel = new StandardKernel(new Bindings());
            repository = kernel.Get<INoteRepository>();
        }
        public void Create(Note note)
        {
            repository.Create(note);
        }

        public void Edit(int id, Note note)
        {
            repository.Edit(id, note);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public Note GetById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Note> GetAll()
        {
            return repository.GetAll();
        }
    }
}
