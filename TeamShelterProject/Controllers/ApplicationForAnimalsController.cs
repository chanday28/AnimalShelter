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
    public class ApplicationForAnimalsController : Controller
    {
        private ShelterProjectEntities db = new ShelterProjectEntities();

        // GET: ApplicationForAnimals
        public ActionResult Index()
        {
            var applicationForAnimals = db.ApplicationForAnimals.Include(a => a.Animal).Include(a => a.Person);
            return View(applicationForAnimals.ToList());
        }

        // GET: ApplicationForAnimals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationForAnimal applicationForAnimal = db.ApplicationForAnimals.Find(id);
            if (applicationForAnimal == null)
            {
                return HttpNotFound();
            }
            return View(applicationForAnimal);
        }

        // GET: ApplicationForAnimals/Create
        public ActionResult Create()
        {
            ViewBag.animalId = new SelectList(db.Animals, "id", "animalType");
            ViewBag.workerId = new SelectList(db.People, "id", "firstName");
            return View();
        }

        // POST: ApplicationForAnimals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,animalId,workerId,firstName,surname,streetAddress,city,zipcode,phone,email,allergies,familySituation,numberOfKids,youngestKidAge,housingType,otherAnimals,animalComment,experience,reasonsToAdopt,timeAlone,tripOptions,possibilityForVet,infoSource,freeComment,owner")] ApplicationForAnimal applicationForAnimal)
        {
            if (ModelState.IsValid)
            {
                db.ApplicationForAnimals.Add(applicationForAnimal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.animalId = new SelectList(db.Animals, "id", "animalType", applicationForAnimal.animalId);
            ViewBag.workerId = new SelectList(db.People, "id", "firstName", applicationForAnimal.workerId);
            return View(applicationForAnimal);
        }

        // GET: ApplicationForAnimals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationForAnimal applicationForAnimal = db.ApplicationForAnimals.Find(id);
            if (applicationForAnimal == null)
            {
                return HttpNotFound();
            }
            ViewBag.animalId = new SelectList(db.Animals, "id", "animalType", applicationForAnimal.animalId);
            ViewBag.workerId = new SelectList(db.People, "id", "firstName", applicationForAnimal.workerId);
            return View(applicationForAnimal);
        }

        // POST: ApplicationForAnimals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,animalId,workerId,firstName,surname,streetAddress,city,zipcode,phone,email,allergies,familySituation,numberOfKids,youngestKidAge,housingType,otherAnimals,animalComment,experience,reasonsToAdopt,timeAlone,tripOptions,possibilityForVet,infoSource,freeComment,owner")] ApplicationForAnimal applicationForAnimal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicationForAnimal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.animalId = new SelectList(db.Animals, "id", "animalType", applicationForAnimal.animalId);
            ViewBag.workerId = new SelectList(db.People, "id", "firstName", applicationForAnimal.workerId);
            return View(applicationForAnimal);
        }

        // GET: ApplicationForAnimals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationForAnimal applicationForAnimal = db.ApplicationForAnimals.Find(id);
            if (applicationForAnimal == null)
            {
                return HttpNotFound();
            }
            return View(applicationForAnimal);
        }

        // POST: ApplicationForAnimals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ApplicationForAnimal applicationForAnimal = db.ApplicationForAnimals.Find(id);
            db.ApplicationForAnimals.Remove(applicationForAnimal);
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
