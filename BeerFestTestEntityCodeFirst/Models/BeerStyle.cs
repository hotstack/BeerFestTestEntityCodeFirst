using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class BeerStyle
    {
        public int BeerStyleID { get; set; }
        public string BeerStyleNumber { get; set; }
        public string StyleName { get; set; }

        // Foreign Key
        public virtual int BeerCategoryID { get; set; }

        // Navigation Properties
        public virtual BeerCategory BeerCategory { get; set; }
        public virtual ICollection<BeerStyleLang> BeerStyleLangs { get; set; }
    }

    public class BeerStyleLang
    {
        public int BeerStyleLangID { get; set; }
        public Lang LangID { get; set; }
        public string StyleName { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public bool? ExternalLink { get; set; }
        public string Pronunciation { get; set; }

        // Foreign Key
        public virtual int BeerStyleID { get; set; }

        // Naviagtion Property
        public virtual BeerStyle BeerStyle { get; set; }
    }
}

