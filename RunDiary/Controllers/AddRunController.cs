using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RunDiary.Controllers
{
    public class AddRunController : ApiController
    {
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
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AddRun/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AddRun/5
        public void Delete(int id)
        {
        }
    }
}
