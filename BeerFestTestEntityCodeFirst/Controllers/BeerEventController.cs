using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BeerFestTestEntityCodeFirst.Models;

namespace BeerFestTestEntityCodeFirst.Controllers
{
    public class BeerEventController : Controller
    {
        private BeerFesDB db = new BeerFesDB();

        // GET: /BeerEvent/
        public ActionResult Index()
        {
            var beerevents = db.BeerEvents.Include(b => b.Beer).Include(b => b.Event);
            return View(beerevents.ToList());
        }

        // GET: /BeerEvent/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            //BeerEvent beerevent = db.BeerEvents.Find(id);
            var beerevents = db.BeerEvents
                .Include(b => b.Beer)
                .Include(b => b.Event)
                .Where(x => x.EventID == id);
            if (beerevents == null)
            {
                return HttpNotFound();
            }
            return View(beerevents);

        }

        // GET: /BeerEvent/Create
        public ActionResult Create()
        {
            ViewBag.BeerID = new SelectList(db.Beers, "BeerID", "Name");
            ViewBag.EventID = new SelectList(db.Events, "EventID", "Name");
            return View();
        }

        // POST: /BeerEvent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="BeerEventID,KyokaiBooth,Kegs,Bottles,KegVolume,BottleVolume,SoldOut,Out,AdditionalInfo,X,Y,BeerID,EventID")] BeerEvent beerevent)
        {
            if (ModelState.IsValid)
            {
                db.BeerEvents.Add(beerevent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BeerID = new SelectList(db.Beers, "BeerID", "Name", beerevent.BeerID);
            ViewBag.EventID = new SelectList(db.Events, "EventID", "Name", beerevent.EventID);
            return View(beerevent);
        }

        // GET: /BeerEvent/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeerEvent beerevent = db.BeerEvents.Find(id);
            if (beerevent == null)
            {
                return HttpNotFound();
            }
            ViewBag.BeerID = new SelectList(db.Beers, "BeerID", "Name", beerevent.BeerID);
            ViewBag.EventID = new SelectList(db.Events, "EventID", "Name", beerevent.EventID);
            return View(beerevent);
        }

        // POST: /BeerEvent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="BeerEventID,KyokaiBooth,Kegs,Bottles,KegVolume,BottleVolume,SoldOut,Out,AdditionalInfo,X,Y,BeerID,EventID")] BeerEvent beerevent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beerevent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BeerID = new SelectList(db.Beers, "BeerID", "Name", beerevent.BeerID);
            ViewBag.EventID = new SelectList(db.Events, "EventID", "Name", beerevent.EventID);
            return View(beerevent);
        }

        // GET: /BeerEvent/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeerEvent beerevent = db.BeerEvents.Find(id);
            if (beerevent == null)
            {
                return HttpNotFound();
            }
            return View(beerevent);
        }

        // POST: /BeerEvent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BeerEvent beerevent = db.BeerEvents.Find(id);
            db.BeerEvents.Remove(beerevent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
