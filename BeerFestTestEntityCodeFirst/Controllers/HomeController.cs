using BeerFestTestEntityCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.SqlServer;

namespace BeerFestTestEntityCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        BeerFesDB _db = new BeerFesDB();

        public ActionResult Index()
        {
            var model = from r in _db.Events
                        where r.EndDate > DateTime.Now
                        orderby r.StartDate ascending
                        select r;
                           /* new HomeEventViewModel
                         {
                             EventID = r.EventID,
                             Name = r.Name,
                             EventStartDate = SqlFunctions.StringConvert(DbFunctions.TruncateTime(r.StartDate)),
                             EventEndDate = DbFunctions.TruncateTime(r.EndDate).ToString(),
                             Icon = r.IconLink
                         };*/
            
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}