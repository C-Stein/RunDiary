using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunDiary.Models
{
    public class RDRepository
    {
        private RDContext _context;
        public RDContext Context {  get { return _context; } }

        public RDRepository()
        {
            _context = new RDContext();
        }

        public RDRepository(RDContext a_context)
        {
            _context = a_context;
        }

        public List<Run> GetAllRuns()
        {
            var query = from run in _context.Runs select run;
            List<Run> found_runs = query.ToList();
            found_runs.Sort();
            return found_runs;
        }


        public void AddRun(Run newRun)
        {
            _context.Runs.Add(newRun);
            _context.SaveChanges();
        }

        public void DeleteRun(Run DeleteRun)
        {
            _context.Runs.Remove(DeleteRun);
            _context.SaveChanges();
        }


        public bool CreateRun(Runner runner1, String runName)
        {
            Run a_run = new Run { RunName = runName };
            bool is_added = true;
            try
            {
                Run added_run = _context.Runs.Add(a_run);
                _context.SaveChanges();
            } catch (Exception)
            {
                is_added = false;
            }
            return is_added;
        }
    }
}