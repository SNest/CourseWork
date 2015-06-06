using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDo.BLL.Helpers.Concrete;
using ToDo.BOL.Entity;

namespace ToDo.PL.MVC.Controllers
{
    public class EventHelperApiController : ApiController
    {
        private readonly EventHelper eventHelper = new EventHelper();
        // GET api/<controller>
        public IEnumerable<Event> Get()
        {
            return eventHelper.GetAll().ToList();
        }

        // GET api/<controller>/5
        public Event Get(int id)
        {
            return eventHelper.GetById(id);
        }
        // POST api/<controller>
        public void Post([FromBody] Event @event)
        {
            eventHelper.Create(@event);
        }

        // PUT api/<controller>
        public void Put([FromBody] Event @event)
        {
            eventHelper.Edit(@event);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            eventHelper.Delete(id);
        }
    }
}
