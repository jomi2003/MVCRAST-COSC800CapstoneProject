using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCRAST.Models;

namespace MVCRAST.Controllers
{
    public class SystemsController : Controller
    {
        private RASTDBContext db = new RASTDBContext();

        // GET: Systems
        public ActionResult Index()
        {
            var systems = db.Systems.Include(s => s.POAM).Include(s => s.SAP).Include(s => s.User);
            return View(systems.ToList());
        }

        // GET: Systems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Systems systems = db.Systems.Find(id);
            if (systems == null)
            {
                return HttpNotFound();
            }
            return View(systems);
        }

        // GET: Systems/Create
        public ActionResult Create()
        {
            ViewBag.POAMID = new SelectList(db.POAMs, "POAMID", "AuthorizationStatus");
            ViewBag.SAPID = new SelectList(db.SAPs, "SAPID", "SAPID");
            ViewBag.UserID = new SelectList(db.Users, "UserID", "FirstName");
            return View();
        }

        // POST: Systems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SystemsID,SystemName,Confidentiality,Integrity,Availability,AssessmentStartDate,AssessmentEndDate,AssessmentPriority,UserID,SAPID,POAMID")] Systems systems)
        {
            if (ModelState.IsValid)
            {
                db.Systems.Add(systems);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.POAMID = new SelectList(db.POAMs, "POAMID", "AuthorizationStatus", systems.POAMID);
            ViewBag.SAPID = new SelectList(db.SAPs, "SAPID", "SAPID", systems.SAPID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "FirstName", systems.UserID);
            return View(systems);
        }

        // GET: Systems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Systems systems = db.Systems.Find(id);
            if (systems == null)
            {
                return HttpNotFound();
            }
            ViewBag.POAMID = new SelectList(db.POAMs, "POAMID", "AuthorizationStatus", systems.POAMID);
            ViewBag.SAPID = new SelectList(db.SAPs, "SAPID", "SAPID", systems.SAPID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "FirstName", systems.UserID);
            return View(systems);
        }

        // POST: Systems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SystemsID,SystemName,Confidentiality,Integrity,Availability,AssessmentStartDate,AssessmentEndDate,AssessmentPriority,UserID,SAPID,POAMID")] Systems systems)
        {
            if (ModelState.IsValid)
            {
                db.Entry(systems).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.POAMID = new SelectList(db.POAMs, "POAMID", "AuthorizationStatus", systems.POAMID);
            ViewBag.SAPID = new SelectList(db.SAPs, "SAPID", "SAPID", systems.SAPID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "FirstName", systems.UserID);
            return View(systems);
        }

        // GET: Systems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Systems systems = db.Systems.Find(id);
            if (systems == null)
            {
                return HttpNotFound();
            }
            return View(systems);
        }

        // POST: Systems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Systems systems = db.Systems.Find(id);
            db.Systems.Remove(systems);
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
