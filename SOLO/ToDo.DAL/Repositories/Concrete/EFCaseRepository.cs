using System;
using System.Collections.Generic;
using System.Data.Entity;
using NLog;
using ToDo.BOL.Entity;
using ToDo.DAL.Repositories.Abstract;

namespace ToDo.DAL.Repositories.Concrete
{
    public class EFCaseRepository : ICaseRepository
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly EFContext context = new EFContext();

        public void Create(Case @case)
        {
            try
            {
                context.Cases.Add(@case);
                logger.Info("Case was added to the context");
                Save();
            }
            catch (Exception exception)
            {
                logger.Error("Case was not added to the context");
                logger.Trace(exception.StackTrace);
            }
        }

        public void Edit(Case @case)
        {
            try
            {
                context.Entry(@case).State = EntityState.Modified; 
                logger.Info("Case changes was added to the context");
                Save();
            }
            catch (Exception exception)
            {
                logger.Error("Case changes was not added to the context");
                logger.Trace(exception.StackTrace);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var c = GetById(id);
                context.Cases.Remove(c);
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
                logger.Info("Case changes was saved to the database");
            }
            catch (Exception exception)
            {
                logger.Info("Case changes was not saved to the database");
                logger.Trace(exception.StackTrace);
            }
        }

        public Case GetById(int id)
        {
            var c = new Case();
            try
            {
                c = context.Cases.Find(id);
                logger.Info("Case was got from the context");
            }
            catch (Exception exception)
            {
                logger.Error("Case was not got from the context");
                logger.Trace(exception.StackTrace);
            }
            return c;
        }

        public IEnumerable<Case> GetAll()
        {
            IEnumerable<Case> cs = null;
            try
            {
                cs = context.Cases;
                logger.Info("Case was got from the context");
            }
            catch (Exception exception)
            {
                logger.Error("Case was not got from the context");
                logger.Trace(exception.StackTrace);
            }
            return cs;
        }
    }
}
