using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SampleClockin.Models;

namespace SampleClockin.Controllers
{
    public class Time1Controller : Controller
    {
        private TimeDataContext db = new TimeDataContext();

        // GET: Time1
        public ActionResult Index()
        {
            return View(db.Times1.ToList());
        }

        // GET: Time1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Time1 time1 = db.Times1.Find(id);
            if (time1 == null)
            {
                return HttpNotFound();
            }
            return View(time1);
        }

        // GET: Time1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Time1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ClockOut,WorkType")] Time1 time1)
        {
            if (ModelState.IsValid)
            {
                db.Times1.Add(time1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(time1);
        }

        // GET: Time1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Time1 time1 = db.Times1.Find(id);
            if (time1 == null)
            {
                return HttpNotFound();
            }
            return View(time1);
        }

        // POST: Time1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ClockOut,WorkType")] Time1 time1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(time1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(time1);
        }

        // GET: Time1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Time1 time1 = db.Times1.Find(id);
            if (time1 == null)
            {
                return HttpNotFound();
            }
            return View(time1);
        }

        // POST: Time1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Time1 time1 = db.Times1.Find(id);
            db.Times1.Remove(time1);
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
