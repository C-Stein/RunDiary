using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RunDiary.Models
{
    public class Runner
    {
        [Key]
        public int RunnerId { get; set; }

        //public virtual ApplicationUser RealUser { get; set; }

        [MaxLength(20)]
        [MinLength(3)]
        [RegularExpression(@"^[a-zA-Z\d]+[-_a-zA-Z\d]{0,2}[a-zA-Z\d]+")]
        public string Handle { get; set; }

        // ICollection, IEnumerable, IQueryable
        public List<Run> Runs { get; set; }

    }
}