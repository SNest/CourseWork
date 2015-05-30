using System;
using System.Collections.Generic;
using NLog;
using ToDo.BOL.Entity;
using ToDo.DAL.Repositories.Abstract;

namespace ToDo.DAL.Repositories.Concrete
{
    public class EFUserRepository : IUserRepository
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly EFContext context = new EFContext();

        public void Create(User user)
        {
            try
            {
                context.Users.Add(user);
                logger.Info("User was added to the context");
                Save();
            }
            catch (Exception exception)
            {
                logger.Error("User was not added to the context");
                logger.Trace(exception.StackTrace);
            }
        }

        public void Edit(int id, User user)
        {
            try
            {
                var u = GetById(id);
                context.Entry(u).CurrentValues.SetValues(user);
                logger.Info("User changes was added to the context");
                Save();
            }
            catch (Exception exception)
            {
                logger.Error("User changes was not added to the context");
                logger.Trace(exception.StackTrace);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var u = GetById(id);
                context.Users.Remove(u);
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
                logger.Info("User changes was saved to the database");
            }
            catch (Exception exception)
            {
                logger.Info("User changes was not saved to the database");
                logger.Trace(exception.StackTrace);
            }
        }

        public User GetById(int id)
        {
            var user = new User();
            try
            {
                user = context.Users.Find(id);
                logger.Info("User was got from the context");
            }
            catch (Exception exception)
            {
                logger.Error("User was not got from the context");
                logger.Trace(exception.StackTrace);
            }
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            IEnumerable<User> users = null;
            try
            {
                users = context.Users;
                logger.Info("User was got from the context");
            }
            catch (Exception exception)
            {
                logger.Error("User was not got from the context");
                logger.Trace(exception.StackTrace);
            }
            return users;
        }
    }
}
