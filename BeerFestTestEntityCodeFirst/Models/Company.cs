using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public Type TypeID { get; set; }
        public DateTime? EstablishDate { get; set; }
        public string PhoneNo { get; set; }

        //Foreign Key
        public int? ImageID { get; set; }

        // Navigation Property
        public virtual ICollection<CompanyLang> CompanyLangs { get; set; }
        public virtual Image Image { get; set; }
    }

    public class CompanyLang
    {
        public int CompanyLangID { get; set; }
        public Lang LangID { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public string Country { get; set; }
        public string Link { get; set; }
        public Lang? LinkLang { get; set; } // if the link is in the localized language
        public string BreweryPR { get; set; }
        public string Prefecture { get; set; }
        public string City { get; set; }
        public string Pronunciation { get; set; }

        // Foreign Key
        public int CompanyID { get; set; }

        // Navigation Property
        public virtual Company Company { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
