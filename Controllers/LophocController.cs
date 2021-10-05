using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaiHopQuang_01.Models;
using LaiHopQuang_01.Data;
using System.Net;
using System.Data.Entity;

namespace LaiHopQuang_01.Controllers
{
    public class LophocController : Controller
    {
        private LaiHopQuang_01Context db = new LaiHopQuang_01Context();

        // GET: LopHocs
        public ActionResult Index()
        {
            return View(db.Lophoc.ToList());
        }

        // GET: LopHocs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lophoc lopHoc = db.Lophoc.Find(id);
            if (lopHoc == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc);
        }

        // GET: LopHocs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LopHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLop,TenLop")] Lophoc lophoc)
        {
            if (ModelState.IsValid)
            {
                db.Lophoc.Add(lophoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lophoc);
        }

        // GET: LopHocs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lophoc lophoc = db.Lophoc.Find(id);
            if (lophoc == null)
            {
                return HttpNotFound();
            }
            return View(lophoc);
        }

        // POST: LopHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLop,TenLop")] Lophoc lophoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lophoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lophoc);
        }

        // GET: LopHocs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lophoc lophoc = db.Lophoc.Find(id);
            if (lophoc == null)
            {
                return HttpNotFound();
            }
            return View(lophoc);
        }

        // POST: LopHocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lophoc lophoc = db.Lophoc.Find(id);
            db.Lophoc.Remove(lophoc);
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