using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class C_代理Controller : Controller
    {
        private Model1 db = new Model1();

        // GET: C_代理
        public async Task<ActionResult> Index()
        {
            return View(await db.C_代理.ToListAsync());
        }

        // GET: C_代理/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_代理 c_代理 = await db.C_代理.FindAsync(id);
            if (c_代理 == null)
            {
                return HttpNotFound();
            }
            return View(c_代理);
        }

        // GET: C_代理/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: C_代理/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "代理名稱,代理Id")] C_代理 c_代理)
        {
            if (ModelState.IsValid)
            {
                db.C_代理.Add(c_代理);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(c_代理);
        }

        // GET: C_代理/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_代理 c_代理 = await db.C_代理.FindAsync(id);
            if (c_代理 == null)
            {
                return HttpNotFound();
            }
            return View(c_代理);
        }

        // POST: C_代理/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "代理名稱,代理Id")] C_代理 c_代理)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c_代理).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(c_代理);
        }

        // GET: C_代理/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_代理 c_代理 = await db.C_代理.FindAsync(id);
            if (c_代理 == null)
            {
                return HttpNotFound();
            }
            return View(c_代理);
        }

        // POST: C_代理/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            C_代理 c_代理 = await db.C_代理.FindAsync(id);
            db.C_代理.Remove(c_代理);
            await db.SaveChangesAsync();
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
