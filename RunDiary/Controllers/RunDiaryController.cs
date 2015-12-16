using RunDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web;

//using System.Web.Http;
using System.Web.Mvc;

namespace RunDiary.Controllers
{
    public class RunDiaryController : Controller
    {
        public RDRepository Repo { get; set; }

        public RunDiaryController() : base()
        {
            Repo = new RDRepository();
        }

        //GET: RunDiary
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            List<Run> my_runs = Repo.GetAllRuns();
            return View(my_runs);
        }

        public ActionResult AddRun()
        {
            return View();
        }

        // GET: api/RunDiary
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RunDiary/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RunDiary
          public void Post([FromBody]string value)
      {
         }

        // PUT: api/RunDiary/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE: api/RunDiary/5
        public void Delete(int id)
        {
        }
    }
}
