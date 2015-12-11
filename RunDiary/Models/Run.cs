using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RunDiary.Models
{
    public class Run
    {
        [Key]
        public int RunID { get; set; }

        public virtual Runner Runner { get; set; }

        [Required]
        public string RunName { get; set; }
        public string RunPlace { get; set; }
        public DateTime RunDate { get; set; }
        public double RunDistance { get; set; }
        public string DistanceUnits { get; set; }
        public double RunTime { get; set; }
        public string RunTimeUnits { get; set; }
        public string Photo { get; set; }
        public string DiaryEntry { get; set; }
        public bool IsRace { get; set; }
    }
}