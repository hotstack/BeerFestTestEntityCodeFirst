using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }

        // Navigation Properties
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Beer> Beers { get; set; }
    }
}
