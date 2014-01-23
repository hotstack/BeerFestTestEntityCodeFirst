using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class CompanyEvent
    {
        public int CompanyEventID { get; set; }
        public int? X { get; set; } // Coordinates of the company on the event map
        public int? Y { get; set; }

        // Foreign Keys
        public int EventID { get; set; }
        public int CompanyID { get; set; }

        // Navigation Properties
        public virtual Event Event { get; set; }
        public virtual Company Company { get; set; }
    }
}

