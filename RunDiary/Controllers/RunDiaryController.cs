﻿using RunDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Web.Http;
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

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Calendar()
        {
            List<Run> my_runs = Repo.GetAllRuns();
            return View(my_runs);
        }

        public ActionResult AddRun()
        {
            Run model = new Run();
            return View(model);
        }

        [HttpPost]
        public ActionResult Calendar(Run newRun)
        {
            
           Repo.AddRun(newRun);
            List<Run> my_runs = Repo.GetAllRuns();
            return View(my_runs);
        }

        public ActionResult EditRun(int id)
        {
            var run = Repo.GetRun(id);
            return View(run);
        }

        [HttpPut]
        public ActionResult EditRun(int id, Run newRun)
        {
            var run = Repo.GetRun(id);
            Repo.DeleteRun(run);
            return View();
        }

        public ActionResult DeleteRun(int id)
        {
            var run = Repo.GetRun(id);
            return View(run);
        }

        //[HttpDelete]
        public ActionResult RunDeleted (Run run)
        {
            //var run = Repo.GetRun(id);
            Repo.DeleteRun(run);
            return View();
        }


    }
}
