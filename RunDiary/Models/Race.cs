using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunDiary.Models
{
    public class Race
    {
        [Key]
        public int RaceID { get; set; }
        public virtual Runner Runner { get; set; }
        public string RaceName { get; set; }
        public int RaceDistance { get; set; }
        public string RaceDistanceUnits { get; set; }
        public string RaceLocation { get; set; }
    }
}