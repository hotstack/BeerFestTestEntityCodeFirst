using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class BeerEvent
    {
        public int BeerEventID { get; set; }
        public bool KyokaiBooth { get; set; }
        public int? Kegs { get; set; }
        public int? Bottles { get; set; }
        public decimal? KegVolume { get; set; }
        public decimal? BottleVolume { get; set; }
        public bool? SoldOut { get; set; } //totally sold out
        public bool? Out { get; set; } //sold out for the day
        public string AdditionalInfo { get; set; }
        public int? X { get; set; } //coordinates beer can be found on the map
        public int? Y { get; set; }

        // Foreign Key
        public int BeerID { get; set; }

        // Navigation Properties
        public virtual ICollection<Company> Companies { get; set; }
        public virtual Beer Beer { get; set; }
    }
}
