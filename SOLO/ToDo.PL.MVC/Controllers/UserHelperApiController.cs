using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ToDo.BLL.Helpers.Concrete;
using ToDo.BOL.Entity;

namespace ToDo.PL.MVC.Controllers
{
    public class UserHelperApiController : ApiController
    {
        private readonly UserHelper userHelper = new UserHelper();
        // GET api/<controller>
        public IEnumerable<User> Get()
        {
           return userHelper.GetAll().ToList();
        }

        // GET api/<controller>/5
        public User Get(int id)
        {
            return userHelper.GetById(id);
        }
        // POST api/<controller>
        public void Post([FromBody] User user)
        {
            userHelper.Create(user);
        }

        // PUT api/<controller>
        public void Put([FromBody] User user)
        {
            userHelper.Edit(user);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            userHelper.Delete(id);
        }
    }
}