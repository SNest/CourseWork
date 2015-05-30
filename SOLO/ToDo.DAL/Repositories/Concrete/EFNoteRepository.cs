using System;
using System.Collections.Generic;
using NLog;
using ToDo.BOL.Entity;
using ToDo.DAL.Repositories.Abstract;

namespace ToDo.DAL.Repositories.Concrete
{
    public class EFNoteRepository : INoteRepository
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly EFContext context = new EFContext();

        public void Create(Note note)
        {
            try
            {
                context.Notes.Add(note);
                logger.Info("Note was added to the context");
                Save();
            }
            catch (Exception exception)
            {
                logger.Error("Note was not added to the context");
                logger.Trace(exception.StackTrace);
            }
        }

        public void Edit(int id, Note note)
        {
            try
            {
                var n = GetById(id);
                context.Entry(n).CurrentValues.SetValues(note);
                logger.Info("Note changes was added to the context");
                Save();
            }
            catch (Exception exception)
            {
                logger.Error("Note changes was not added to the context");
                logger.Trace(exception.StackTrace);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var n = GetById(id);
                context.Notes.Remove(n);
                logger.Info("Changes was saved to the database");
                Save();
            }
            catch (Exception exception)
            {
                logger.Info("Changes was not saved to the database");
                logger.Trace(exception.StackTrace);
            }
        }

        public void Save()
        {
            try
            {
                context.SaveChanges();
                logger.Info("Note changes was saved to the database");
            }
            catch (Exception exception)
            {
                logger.Info("Note changes was not saved to the database");
                logger.Trace(exception.StackTrace);
            }
        }

        public Note GetById(int id)
        {
            var n = new Note();
            try
            {
                n = context.Notes.Find(id);
                logger.Info("Note was got from the context");
            }
            catch (Exception exception)
            {
                logger.Error("Note was not got from the context");
                logger.Trace(exception.StackTrace);
            }
            return n;
        }

        public IEnumerable<Note> GetAll()
        {
            IEnumerable<Note> ns = null;
            try
            {
                ns = context.Notes;
                logger.Info("Note was got from the context");
            }
            catch (Exception exception)
            {
                logger.Error("Note was not got from the context");
                logger.Trace(exception.StackTrace);
            }
            return ns;
        }
    }
}
