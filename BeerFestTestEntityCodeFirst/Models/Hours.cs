using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class Hours
    {
        public int HoursID { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public DateTime? GatesOpen { get; set; }
        public DateTime? LastCall { get; set; }

        // Foreign Key
        public int EventID { get; set; }

        // Navigation Property
        public virtual Event Event { get; set; }

    }
}