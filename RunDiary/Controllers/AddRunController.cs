//using Microsoft.Owin;
using RunDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace RunDiary.Controllers
{
    public class AddRunController : ApiController
       

    {
        private RDRepository repo = new RDRepository();

        // GET: api/AddRun
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AddRun/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AddRun
        public void Post(Run newRun)
        {
            repo.AddRun(newRun);
        }


        // PUT: api/AddRun/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AddRun/5
        public void Delete(int id)
        {
            //var query = from run in _context.Runs select run where runID == id;
            //Run runToDelete = find the run with matching id
           // repo.DeleteRun(runToDelete);
        }
    }
}
