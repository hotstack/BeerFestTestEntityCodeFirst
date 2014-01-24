using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class HomeEventViewModel
    {
        public int EventID { get; set; }
        public string Icon { get; set; }
        public string EventStartDate { get; set; }
        public string EventEndDate { get; set; }
        public string Name { get; set; }
    }
}