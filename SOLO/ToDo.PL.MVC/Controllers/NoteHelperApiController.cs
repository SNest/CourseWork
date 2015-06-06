using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ToDo.BLL.Helpers.Concrete;
using ToDo.BOL.Entity;

namespace ToDo.PL.MVC.Controllers
{
    public class NoteHelperApiController : ApiController
    {
        private readonly NoteHelper noteHelper = new NoteHelper();
        // GET api/<controller>
        public IEnumerable<Note> Get()
        {
            return noteHelper.GetAll().ToList();
        }

        // GET api/<controller>/5
        public Note Get(int id)
        {
            return noteHelper.GetById(id);
        }
        // POST api/<controller>
        public void Post([FromBody] Note note)
        {
            noteHelper.Create(note);
        }

        // PUT api/<controller>
        public void Put([FromBody] Note note)
        {
            noteHelper.Edit(note);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            noteHelper.Delete(id);
        }
    }
}