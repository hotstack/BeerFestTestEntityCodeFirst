using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class Beer
    {
        public int BeerID { get; set; }
        public string Name { get; set; }
        public decimal? ABV { get; set; }
        public int? IBU { get; set; }
        [Timestamp]
        public byte[] Edited { get; set; }

        //Foreign Keys
        public int? ImageID { get; set; }
        public int? BeerStyleID { get; set; }
        
        //Navigation Properties
        public virtual ICollection<Company> Companies { get; set; }  //most often these will be a single... could I also combine them and just look for beer.Company.TypeID = whatever?
        public virtual BeerStyle BeerStyle { get; set; }
        public virtual Image Image { get; set; }  //this corresponds to the "official" image
        public virtual ICollection<Image> Images { get; set; } // this is a collection of all the images including the one above probably
        public virtual ICollection<BeerLang> BeerLangs { get; set; }
    }

    public class BeerLang
    {
        public int BeerLangID { get; set; }
        public Lang LangID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Pronunciation { get; set; }

        // Foreign Key
        public int BeerID { get; set; }

        //Navigation Property
        public virtual Beer Beer { get; set; }
    }
}

