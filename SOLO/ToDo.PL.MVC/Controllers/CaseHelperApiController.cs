using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ToDo.BLL.Helpers.Concrete;
using ToDo.BOL.Entity;

namespace ToDo.PL.MVC.Controllers
{
    public class CaseHelperApiController : ApiController
    {
        private readonly CaseHelper caseHelper = new CaseHelper();
        // GET api/<controller>
        public IEnumerable<Case> Get()
        {
            return caseHelper.GetAll().ToList();
        }

        // GET api/<controller>/5
        public Case Get(int id)
        {
            return caseHelper.GetById(id);
        }
        // POST api/<controller>
        public void Post([FromBody] Case @case)
        {
            caseHelper.Create(@case);
        }

        // PUT api/<controller>
        public void Put([FromBody] Case @case)
        {
            caseHelper.Edit(@case);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            caseHelper.Delete(id);
        }
    }
}
