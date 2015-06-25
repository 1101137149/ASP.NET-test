using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalASP.Models;

namespace FinalASP.Controllers
{
    public class ms_dataController : Controller
    {
        private DatabaseEntities_ms db = new DatabaseEntities_ms();

        // GET: ms_data
        public ActionResult Index()
        {
            return View(db.ms_data.ToList());
        }

        // GET: ms_data/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ms_data ms_data = db.ms_data.Find(id);
            if (ms_data == null)
            {
                return HttpNotFound();
            }
            return View(ms_data);
        }

        // GET: ms_data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ms_data/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,email,message,time")] ms_data ms_data)
        {
            if (ModelState.IsValid)
            {
                db.ms_data.Add(ms_data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ms_data);
        }

        // GET: ms_data/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ms_data ms_data = db.ms_data.Find(id);
            if (ms_data == null)
            {
                return HttpNotFound();
            }
            return View(ms_data);
        }

        // POST: ms_data/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,email,message,time")] ms_data ms_data)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ms_data).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ms_data);
        }

        // GET: ms_data/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ms_data ms_data = db.ms_data.Find(id);
            if (ms_data == null)
            {
                return HttpNotFound();
            }
            return View(ms_data);
        }

        // POST: ms_data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ms_data ms_data = db.ms_data.Find(id);
            db.ms_data.Remove(ms_data);
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
