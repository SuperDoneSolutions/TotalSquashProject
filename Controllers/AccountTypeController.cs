﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TotalSquash.Models;

namespace TotalSquash.Controllers
{
    public class AccountTypeController : Controller
    {
        private PrimarySquashDBContext db = new PrimarySquashDBContext();

        // GET: AccountType
        public ActionResult Index()
        {
            return View(db.AccountTypes.ToList());
        }

        // GET: AccountType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountType accountType = db.AccountTypes.Find(id);
            if (accountType == null)
            {
                return HttpNotFound();
            }
            return View(accountType);
        }

        // GET: AccountType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "accountId,description")] AccountType accountType)
        {
            if (ModelState.IsValid)
            {
                db.AccountTypes.Add(accountType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accountType);
        }

        // GET: AccountType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountType accountType = db.AccountTypes.Find(id);
            if (accountType == null)
            {
                return HttpNotFound();
            }
            return View(accountType);
        }

        // POST: AccountType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "accountId,description")] AccountType accountType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accountType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accountType);
        }

        // GET: AccountType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountType accountType = db.AccountTypes.Find(id);
            if (accountType == null)
            {
                return HttpNotFound();
            }
            return View(accountType);
        }

        // POST: AccountType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountType accountType = db.AccountTypes.Find(id);
            db.AccountTypes.Remove(accountType);
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
