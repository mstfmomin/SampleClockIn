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
    public class TimesController : Controller
    {
        private TimeDataContext db = new TimeDataContext();

        // GET: Times
        public ActionResult Index()
        {


            
            
            return View(db.Times.ToList());
        }

        // GET: Times/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Time time = db.Times.Find(id);
            if (time == null)
            {
                return HttpNotFound();
            }
            return View(time);
        }
        // GET: Times/Create


        public ActionResult Create()
        {
            



            return View(new TimeDataContext());

        }

        // POST: Times/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] Time time, Time1 time1, TotalTime totalTimes, string buttonType)
        {


            if (buttonType == "ClockIn")
            {

                if (ModelState.IsValid)
                {
                    db.Times.Add(time);
                    db.SaveChanges();
                    return RedirectToAction("Create");
                }
                return View();
            }


            if (buttonType == "ClockOut")
            {
                if (ModelState.IsValid)
                {
                    db.Times1.Add(time1);
                    db.SaveChanges();

                    db.TotalTimes.Add(totalTimes);
                    db.SaveChanges();

                    return RedirectToAction("Create");
                }

                return View();
            }

            //if (buttonType == "TotalTime")
            //{
            //    if (ModelState.IsValid)
            //    {
            //        //projects = db.Times.Join(db.Times1, s => s.Id, d => d.Id,
            //        //  (s, d) => new { ClockInTime = s.ClockIn, ClockOutTime = d.ClockOut })
            //        //    .Select(a => a.ClockInTime - a.ClockOutTime);

            //        db.TotalTimes.Add(projects);
            //        db.SaveChanges();
            //        return RedirectToAction("Create");
            //    }

            //    return View();
            //}

            //var ttime= 
            //    from Ctime in db.Times
            //    join  Otime in db.Times1 on Ctime.Id equals Otime.Id
            //    select new (NewTime => Ctime.ClockIn-Otime.ClockOut );

          //  var projects = db.Times.Join(db.Times1, s => s.Id, d => d.Id,
          //(s, d) => new { ClockInTime = s.ClockIn, ClockOutTime = d.ClockOut })
          //  .Select(a => a.ClockInTime - a.ClockOutTime);
          //  db.TotalTimes.Add(projects);

            return View();
        }

        // POST: Times/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ClockIn")] Time time)
        {
            if (ModelState.IsValid)
            {
                db.Entry(time).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(time);
        }

        // GET: Times/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Time time = db.Times.Find(id);
            if (time == null)
            {
                return HttpNotFound();
            }
            return View(time);
        }

        // POST: Times/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Time time = db.Times.Find(id);
            db.Times.Remove(time);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        //
        // GET: /Notes/_CreateNote - Partial view
        public ViewResult _ClockOut()
        {
            return View("_ClockOut");
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
