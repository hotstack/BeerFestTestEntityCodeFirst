using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class Event
    {
        public int EventID { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? EventFinish { get; set; }
        public decimal? TicketPrice { get; set; }
        public decimal? PreOrderTicketPrice { get; set; }
        public DateTime? TicketSalesStart { get; set; }
        public DateTime? PreOrderTicketSalesEnd { get; set; }
        public bool? ComingSoon { get; set; }
        public bool? MonthOnly { get; set; }
        public string TwitterUserName { get; set; }

        // Navigation Property
        public virtual ICollection<EventLang> EventLangs { get; set; }
    }

    public class EventLang
    {
        public int EventLangID { get; set; }
        public Lang LangID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Directions { get; set; }
        public string TicketOrder { get; set; }
        public string Map { get; set; }
        public string Pronunciation { get; set; }
        
        // Foreign Key
        public int EventID { get; set; }

        // Navigation Property
        public virtual Event Event { get; set; }
    }
}
