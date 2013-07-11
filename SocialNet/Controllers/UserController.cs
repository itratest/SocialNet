using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SocialNet.Models;

namespace SocialNet.Controllers
{
    public class UserController : Controller
    {
        private UsersContext db = new UsersContext();

        //
        // GET: /User/

        public ActionResult Index()
        {
            var data = db.UserData.Include(a => a.Name).Include(a => a.FirstName).Include(a=>a.City);
            return View(data.ToList());
        }

        //
        // GET: /User/Details/5

        public ActionResult Details(int id = 0)
        {
            UsersDataModel usersdatamodel = db.UserData.Find(id);
            if (usersdatamodel == null)
            {
                return HttpNotFound();
            }
            return View(usersdatamodel);
        }

        //
        // GET: /User/Create

        public ActionResult Create()
        {
            ViewBag.CityID = new SelectList(db.Cities, "GenreId", "Name");
            return View();
        }

        //
        // POST: /User/Create

        [HttpPost]
        public ActionResult Create(UsersDataModel usersdatamodel)
        {
            if (ModelState.IsValid)
            {
                db.UserData.Add(usersdatamodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usersdatamodel);
        }

        //
        // GET: /User/Edit/5

        public ActionResult Edit(int id = 0)
        {
            UsersDataModel usersdatamodel = db.UserData.Find(id);
            if (usersdatamodel == null)
            {
                return HttpNotFound();
            }
            return View(usersdatamodel);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        public ActionResult Edit(UsersDataModel usersdatamodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usersdatamodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usersdatamodel);
        }

        //
        // GET: /User/Delete/5

        public ActionResult Delete(int id = 0)
        {
            UsersDataModel usersdatamodel = db.UserData.Find(id);
            if (usersdatamodel == null)
            {
                return HttpNotFound();
            }
            return View(usersdatamodel);
        }

        //
        // POST: /User/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            UsersDataModel usersdatamodel = db.UserData.Find(id);
            db.UserData.Remove(usersdatamodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}