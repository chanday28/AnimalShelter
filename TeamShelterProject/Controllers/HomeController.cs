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
    public class HomeController : Controller
    {
        private ShelterProjectEntities db = new ShelterProjectEntities();
        public ActionResult Index()
        {
            var animals = db.Animals;
            ViewBag.Animals = animals.ToList();
            var shelters = db.Shelters;
            ViewBag.Shelters = shelters.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var shelters = db.People.Include(p => p.Shelter);
            return View(shelters);
        }
    }
};