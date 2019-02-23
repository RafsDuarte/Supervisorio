using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Supervisorio.Web;

namespace Supervisorio.Web.Controllers
{
    public class FROTAController : Controller
    {
        private UsinaEntities db = new UsinaEntities();


        public ActionResult Create()
        {
            return View();
        }

        // POST: FROTA/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FROTA fROTA)
        {
            if (ModelState.IsValid)
            {
                db.FROTA.Add(fROTA);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(fROTA);
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
