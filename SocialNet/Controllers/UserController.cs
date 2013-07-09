﻿using System;
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
            return View(db.UsersDataModels.ToList());
        }

        //
        // GET: /User/Details/5

        public ActionResult Details(int id = 0)
        {
            UsersDataModel usersdatamodel = db.UsersDataModels.Find(id);
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
            return View();
        }

        //
        // POST: /User/Create

        [HttpPost]
        public ActionResult Create(UsersDataModel usersdatamodel)
        {
            if (ModelState.IsValid)
            {
                db.UsersDataModels.Add(usersdatamodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usersdatamodel);
        }

        //
        // GET: /User/Edit/5

        public ActionResult Edit(int id = 0)
        {
            UsersDataModel usersdatamodel = db.UsersDataModels.Find(id);
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
            UsersDataModel usersdatamodel = db.UsersDataModels.Find(id);
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
            UsersDataModel usersdatamodel = db.UsersDataModels.Find(id);
            db.UsersDataModels.Remove(usersdatamodel);
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