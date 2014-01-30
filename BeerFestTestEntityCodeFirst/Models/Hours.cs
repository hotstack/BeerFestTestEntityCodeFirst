using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class Hours
    {
        public int HoursID { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}({0:ddd})")]
        public DateTime? Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime? StartTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime? FinishTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime? GatesOpen { get; set; }
        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime? LastCall { get; set; }

        // Foreign Key
        public int EventID { get; set; }

        // Navigation Property
        public virtual Event Event { get; set; }

    }
}