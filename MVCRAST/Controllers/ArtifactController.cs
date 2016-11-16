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
    public class ArtifactController : Controller
    {
        private RASTDBContext db = new RASTDBContext();

        // GET: RAST
        public ActionResult Index()
        {
            var artifacts = db.Artifacts.Include(a => a.FileTemplate);
            return View(artifacts.ToList());
        }

        // GET: RAST/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artifact artifact = db.Artifacts.Find(id);
            if (artifact == null)
            {
                return HttpNotFound();
            }
            return View(artifact);
        }

        // GET: RAST/Create
        public ActionResult Create()
        {
            ViewBag.FileTemplateID = new SelectList(db.FileTemplates, "FileTemplateID", "FileName");
            return View();
        }

        // POST: RAST/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArtifactID,ArtifactName,Description,FileTemplateID")] Artifact artifact)
        {
            if (ModelState.IsValid)
            {
                db.Artifacts.Add(artifact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FileTemplateID = new SelectList(db.FileTemplates, "FileTemplateID", "FileName", artifact.FileTemplateID);
            return View(artifact);
        }

        // GET: RAST/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artifact artifact = db.Artifacts.Find(id);
            if (artifact == null)
            {
                return HttpNotFound();
            }
            ViewBag.FileTemplateID = new SelectList(db.FileTemplates, "FileTemplateID", "FileName", artifact.FileTemplateID);
            return View(artifact);
        }

        // POST: RAST/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArtifactID,ArtifactName,Description,FileTemplateID")] Artifact artifact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artifact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FileTemplateID = new SelectList(db.FileTemplates, "FileTemplateID", "FileName", artifact.FileTemplateID);
            return View(artifact);
        }

        // GET: RAST/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artifact artifact = db.Artifacts.Find(id);
            if (artifact == null)
            {
                return HttpNotFound();
            }
            return View(artifact);
        }

        // POST: RAST/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artifact artifact = db.Artifacts.Find(id);
            db.Artifacts.Remove(artifact);
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
