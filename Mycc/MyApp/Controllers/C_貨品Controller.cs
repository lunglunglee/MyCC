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
    public class C_貨品Controller : Controller
    {
        private Model1 db = new Model1();

        // GET: C_貨品
        public async Task<ActionResult> Index()
        {
            return View(await db.C_貨品.ToListAsync());
        }

        // GET: C_貨品/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_貨品 c_貨品 = await db.C_貨品.FindAsync(id);
            if (c_貨品 == null)
            {
                return HttpNotFound();
            }
            return View(c_貨品);
        }

        // GET: C_貨品/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: C_貨品/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "貨品名稱,貨品Id,價格")] C_貨品 c_貨品)
        {
            if (ModelState.IsValid)
            {
                db.C_貨品.Add(c_貨品);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(c_貨品);
        }

        // GET: C_貨品/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_貨品 c_貨品 = await db.C_貨品.FindAsync(id);
            if (c_貨品 == null)
            {
                return HttpNotFound();
            }
            return View(c_貨品);
        }

        // POST: C_貨品/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "貨品名稱,貨品Id,價格")] C_貨品 c_貨品)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c_貨品).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(c_貨品);
        }

        // GET: C_貨品/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_貨品 c_貨品 = await db.C_貨品.FindAsync(id);
            if (c_貨品 == null)
            {
                return HttpNotFound();
            }
            return View(c_貨品);
        }

        // POST: C_貨品/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            C_貨品 c_貨品 = await db.C_貨品.FindAsync(id);
            db.C_貨品.Remove(c_貨品);
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
