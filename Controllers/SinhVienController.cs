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
    public class SinhVienController : Controller
    {
        private LaiHopQuang_01Context db = new LaiHopQuang_01Context();

        // GET: LopHocs
        public ActionResult Index()
        {
            return View(db.SinhVien.ToList());
        }

        // GET: SinhVien/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien SinhVien = db.SinhVien.Find(id);
            if (SinhVien == null)
            {
                return HttpNotFound();
            }
            return View(SinhVien);
        }

        // GET: SinhVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SinhVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Masinhvien,Hovaten,Malop")] SinhVien SinhVien)
        {
            if (ModelState.IsValid)
            {
                db.SinhVien.Add(SinhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(SinhVien);
        }

        // GET: SinhVien/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien SinhVien = db.SinhVien.Find(id);
            if (SinhVien == null)
            {
                return HttpNotFound();
            }
            return View(SinhVien);
        }

        // POST: SinhVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Masinhvien,hovaten,Malop")] SinhVien SinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(SinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(SinhVien);
        }

        // GET: SinhVien/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien SinhVien = db.SinhVien.Find(id);
            if (SinhVien == null)
            {
                return HttpNotFound();
            }
            return View(SinhVien);
        }

        // POST: SinhVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SinhVien SinhVien = db.SinhVien.Find(id);
            db.SinhVien.Remove(SinhVien);
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