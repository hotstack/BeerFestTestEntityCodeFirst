using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class BeerCategory
    {
        public int BeerCategoryID { get; set; }
        public string CategoryName { get; set; }

        // Navigation Property
        public virtual ICollection<BeerCategoryLang> BeerCategoryLangs { get; set; }
    }

    public class BeerCategoryLang
    {
        public int BeerCategoryLangID { get; set; }
        public Lang LangID { get; set; }
        public string Pronunciation { get; set; }
        public string CategoryName { get; set; }

        // Foreign Keys
        public int BeerCategoryID { get; set; }

        // Navigation Property
        public virtual BeerCategory BeerCategory { get; set; }

    }
}
