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
    public class EventLangController : Controller
    {
        private BeerFesDB db = new BeerFesDB();

        // GET: /EventLang/
        public ActionResult Index()
        {
            var eventlangs = db.EventLangs.Include(e => e.Event);
            return View(eventlangs.ToList());
        }

        // GET: /EventLang/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventLang eventlang = db.EventLangs.Find(id);
            if (eventlang == null)
            {
                return HttpNotFound();
            }
            return View(eventlang);
        }

        // GET: /EventLang/Create
        public ActionResult Create()
        {
            ViewBag.EventID = new SelectList(db.Events, "EventID", "Name");
            return View();
        }

        // POST: /EventLang/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="EventLangID,LangID,Name,Description,Directions,TicketOrder,Map,Pronunciation,EventID")] EventLang eventlang)
        {
            if (ModelState.IsValid)
            {
                db.EventLangs.Add(eventlang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventID = new SelectList(db.Events, "EventID", "Name", eventlang.EventID);
            return View(eventlang);
        }

        // GET: /EventLang/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventLang eventlang = db.EventLangs.Find(id);
            if (eventlang == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventID = new SelectList(db.Events, "EventID", "Name", eventlang.EventID);
            return View(eventlang);
        }

        // POST: /EventLang/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="EventLangID,LangID,Name,Description,Directions,TicketOrder,Map,Pronunciation,EventID")] EventLang eventlang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventlang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventID = new SelectList(db.Events, "EventID", "Name", eventlang.EventID);
            return View(eventlang);
        }

        // GET: /EventLang/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventLang eventlang = db.EventLangs.Find(id);
            if (eventlang == null)
            {
                return HttpNotFound();
            }
            return View(eventlang);
        }

        // POST: /EventLang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventLang eventlang = db.EventLangs.Find(id);
            db.EventLangs.Remove(eventlang);
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
