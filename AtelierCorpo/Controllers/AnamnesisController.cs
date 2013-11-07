using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AtelierCorpo.Models;

namespace AtelierCorpo.Controllers
{
    public class AnamnesisController : Controller
    {
        private AtelierCorpoContext db = new AtelierCorpoContext();

        // GET: /Anamnesis/
        public ActionResult Index()
        {
            return View(db.Anamnesises.ToList());
        }

        // GET: /Anamnesis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anamnesis anamnesis = db.Anamnesises.Find(id);
            if (anamnesis == null)
            {
                return HttpNotFound();
            }
            return View(anamnesis);
        }

        // GET: /Anamnesis/Create
        public ActionResult Create()
        {
            ViewBag.Questions = db.Questions.ToList();
            return View();
        }

        // POST: /Anamnesis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Answer,Complement")] Anamnesis anamnesis)
        {
            if (ModelState.IsValid)
            {
                db.Anamnesises.Add(anamnesis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anamnesis);
        }

        // GET: /Anamnesis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anamnesis anamnesis = db.Anamnesises.Find(id);
            if (anamnesis == null)
            {
                return HttpNotFound();
            }
            return View(anamnesis);
        }

        // POST: /Anamnesis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Answer,Complement")] Anamnesis anamnesis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anamnesis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anamnesis);
        }

        // GET: /Anamnesis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anamnesis anamnesis = db.Anamnesises.Find(id);
            if (anamnesis == null)
            {
                return HttpNotFound();
            }
            return View(anamnesis);
        }

        // POST: /Anamnesis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Anamnesis anamnesis = db.Anamnesises.Find(id);
            db.Anamnesises.Remove(anamnesis);
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
