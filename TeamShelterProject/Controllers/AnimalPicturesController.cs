using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TeamShelterProject.Models;

namespace TeamShelterProject.Controllers
{
    public class AnimalPicturesController : Controller
    {
        private ShelterProjectEntities db = new ShelterProjectEntities();

        // GET: AnimalPictures
        public ActionResult Index()
        {
            var animalPictures = db.AnimalPictures.Include(a => a.Animal);
            return View(animalPictures.ToList());
        }

        // GET: AnimalPictures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalPicture animalPicture = db.AnimalPictures.Find(id);
            if (animalPicture == null)
            {
                return HttpNotFound();
            }
            return View(animalPicture);
        }

        // GET: AnimalPictures/Create
        public ActionResult Create()
        {
            ViewBag.animalId = new SelectList(db.Animals, "id", "animalType");
            return View();
        }

        // POST: AnimalPictures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,animalId,imageUrl")] AnimalPicture animalPicture)
        {
            if (ModelState.IsValid)
            {
                db.AnimalPictures.Add(animalPicture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.animalId = new SelectList(db.Animals, "id", "animalType", animalPicture.animalId);
            return View(animalPicture);
        }

        // GET: AnimalPictures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalPicture animalPicture = db.AnimalPictures.Find(id);
            if (animalPicture == null)
            {
                return HttpNotFound();
            }
            ViewBag.animalId = new SelectList(db.Animals, "id", "animalType", animalPicture.animalId);
            return View(animalPicture);
        }

        // POST: AnimalPictures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,animalId,imageUrl")] AnimalPicture animalPicture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(animalPicture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.animalId = new SelectList(db.Animals, "id", "animalType", animalPicture.animalId);
            return View(animalPicture);
        }

        // GET: AnimalPictures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalPicture animalPicture = db.AnimalPictures.Find(id);
            if (animalPicture == null)
            {
                return HttpNotFound();
            }
            return View(animalPicture);
        }

        // POST: AnimalPictures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnimalPicture animalPicture = db.AnimalPictures.Find(id);
            db.AnimalPictures.Remove(animalPicture);
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
