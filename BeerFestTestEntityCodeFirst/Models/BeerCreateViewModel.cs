using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class BeerCreateViewModel
    {
        public Beer Beer { get; set; }

        //Company view
        public SelectList CompanyList { get; set; }

        public SelectList BeerStyleList { get; set; }
    }
}