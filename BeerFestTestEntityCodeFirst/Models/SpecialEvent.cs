using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class SpecialEvent
    {
        public int SpecialEventID { get; set; }
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool AllDay { get; set; }

        // Foreign Keys
        public int? EventID { get; set; }
        public int? HoursID { get; set; }

        // Navigation Property

        public virtual Event Event { get; set; }
        public virtual Hours Hours { get; set; }
        public virtual ICollection<SpecialEventLang> SpecialEventLangs { get; set; }
    }

    public class SpecialEventLang
    {
        public int SpecialEventLangID { get; set; }
        public Lang LangID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Pronunciation { get; set; }

        // Foreign Key
        public int SpecialEventID { get; set; }

        // Navigation Property
        public virtual SpecialEvent SpecialEvent { get; set; }
    }
}