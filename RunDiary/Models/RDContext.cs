using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RunDiary.Models
{
    public class RDContext : ApplicationDbContext
    {
        public virtual DbSet<Runner> Runners { get; set; }
        public virtual DbSet<Run> Runs { get; set; }
    }
}