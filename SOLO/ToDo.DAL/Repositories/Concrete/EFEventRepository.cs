using System;
using System.Collections.Generic;
using System.Data.Entity;
using NLog;
using ToDo.BOL.Entity;
using ToDo.DAL.Repositories.Abstract;

namespace ToDo.DAL.Repositories.Concrete
{
    public class EFEventRepository : IEventRepository
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly EFContext context = new EFContext();

        public void Create(Event @event)
        {
            try
            {
                context.Events.Add(@event);
                logger.Info("Event was added to the context");
                Save();
            }
            catch (Exception exception)
            {
                logger.Error("Event was not added to the context");
                logger.Trace(exception.StackTrace);
            }
        }

        public void Edit(Event @event)
        {
            try
            {
                context.Entry(@event).State = EntityState.Modified; 
                logger.Info("Event changes was added to the context");
                Save();
            }
            catch (Exception exception)
            {
                logger.Error("Event changes was not added to the context");
                logger.Trace(exception.StackTrace);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var e = GetById(id);
                context.Events.Remove(e);
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
                logger.Info("Event changes was saved to the database");
            }
            catch (Exception exception)
            {
                logger.Info("Event changes was not saved to the database");
                logger.Trace(exception.StackTrace);
            }
        }

        public Event GetById(int id)
        {
            var e = new Event();
            try
            {
                e = context.Events.Find(id);
                logger.Info("Event was got from the context");
            }
            catch (Exception exception)
            {
                logger.Error("Event was not got from the context");
                logger.Trace(exception.StackTrace);
            }
            return e;
        }

        public IEnumerable<Event> GetAll()
        {
            IEnumerable<Event> es = null;
            try
            {
                es = context.Events;
                logger.Info("Event was got from the context");
            }
            catch (Exception exception)
            {
                logger.Error("Event was not got from the context");
                logger.Trace(exception.StackTrace);
            }
            return es;
        }
    }
}
