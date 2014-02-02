﻿using System;
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
    public class BeerController : Controller
    {
        private BeerFesDB db = new BeerFesDB();

        // GET: /Beer/
        public ActionResult Index()
        {
            var beers = db.Beers.Include(b => b.BeerStyle);
            return View(beers.ToList());
        }

        // GET: /Beer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beer beer = db.Beers.Find(id);
            if (beer == null)
            {
                return HttpNotFound();
            }
            return View(beer);
        }

        // GET: /Beer/Create
        public ActionResult Create()
        {
            ViewBag.BeerStyleID = new SelectList(db.BeerStyles, "BeerStyleID", "BeerStyleNumber");
            return View();
        }

        // POST: /Beer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="BeerID,Name,ABV,IBU,Edited,ImageID,BeerStyleID")] Beer beer)
        {
            if (ModelState.IsValid)
            {
                db.Beers.Add(beer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BeerStyleID = new SelectList(db.BeerStyles, "BeerStyleID", "BeerStyleNumber", beer.BeerStyleID);
            return View(beer);
        }

        // GET: /Beer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beer beer = db.Beers.Find(id);
            if (beer == null)
            {
                return HttpNotFound();
            }
            ViewBag.BeerStyleID = new SelectList(db.BeerStyles, "BeerStyleID", "BeerStyleNumber", beer.BeerStyleID);
            return View(beer);
        }

        // POST: /Beer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="BeerID,Name,ABV,IBU,Edited,ImageID,BeerStyleID")] Beer beer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BeerStyleID = new SelectList(db.BeerStyles, "BeerStyleID", "BeerStyleNumber", beer.BeerStyleID);
            return View(beer);
        }

        // GET: /Beer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beer beer = db.Beers.Find(id);
            if (beer == null)
            {
                return HttpNotFound();
            }
            return View(beer);
        }

        // POST: /Beer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Beer beer = db.Beers.Find(id);
            db.Beers.Remove(beer);
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
