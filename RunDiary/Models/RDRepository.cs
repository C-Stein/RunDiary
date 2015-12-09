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
    }
}