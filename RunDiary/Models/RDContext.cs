using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RunDiary.Models
{
    public class RDContext : DbContext
    {
        public virtual DbSet<Runner> Runners { get; set; }
        public DbSet<Run> Runs { get; set; }
    }
}