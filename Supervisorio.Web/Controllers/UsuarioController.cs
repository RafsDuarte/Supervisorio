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
    public class USUARIOController : Controller
    {
        private UsinaEntities db = new UsinaEntities();

        

        // GET: USUARIO/Create
        public ActionResult Create()
        {
            ViewBag.IDFuncao = new SelectList(db.FUNCAO, "ID", "Nome");
            return View();
        }

        // POST: USUARIO/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {
                db.USUARIO.Add(uSUARIO);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(uSUARIO);
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
