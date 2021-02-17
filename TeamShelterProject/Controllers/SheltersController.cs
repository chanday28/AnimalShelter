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
    public class SheltersController : Controller
    {
        private ShelterProjectEntities db = new ShelterProjectEntities();

   

        // GET: Shelters
        public ActionResult Index()
        {
            var people = db.Shelters.Include(a => a.People);
            return View(db.Shelters.ToList());
        }

        // GET: Shelters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            /*
            DbSet<Shelter> shelterinDbSet = db.Shelters;
            List<Shelter> shelterInListOfShelters = shelterinDbSet.ToList();
            Shelter shelter1 = db.Shelters.ToList()[0]; //get the only shelter we should get, if empty would crush
            */
           // Shelter shelter = db.Shelters.Include(s => s.People).Where(s=> s.id == id).FirstOrDefault(); //produces db set of 1 or 0 shelters, firstOrdefault takes the 1st item or null. Same as Find. We can't use find with Include. 
            // or better
            Shelter shelter = db.Shelters.Include(s => s.People).SingleOrDefault(s=> s.id == id);
            if (shelter == null)
            {
                return HttpNotFound();
            }
            return View(shelter);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Details(bool workerCheckBox, bool volunteerCheckBox)
        //{
            

        //    return View(shelter);
        //}

        // GET: Shelters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shelters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,streetAddress,phone,email")] Shelter shelter)
        {
            if (ModelState.IsValid)
            {
                db.Shelters.Add(shelter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shelter);
        }

        // GET: Shelters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shelter shelter = db.Shelters.Find(id);
            if (shelter == null)
            {
                return HttpNotFound();
            }
            return View(shelter);
        }

        // POST: Shelters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,streetAddress,phone,email")] Shelter shelter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shelter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shelter);
        }

        // GET: Shelters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shelter shelter = db.Shelters.Find(id);
            if (shelter == null)
            {
                return HttpNotFound();
            }
            return View(shelter);
        }

        // POST: Shelters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shelter shelter = db.Shelters.Find(id);
            db.Shelters.Remove(shelter);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Partial()
        {
            db.Shelters.ToList();
            return PartialView();
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
