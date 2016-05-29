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
    public class 貨品表Controller : Controller
    {
        private Model1 db = new Model1();

        // GET: 貨品表
        public async Task<ActionResult> Index()
        {
            return View(await db.貨品表.ToListAsync());
        }

        // GET: 貨品表/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            貨品表 貨品表 = await db.貨品表.FindAsync(id);
            if (貨品表 == null)
            {
                return HttpNotFound();
            }
            return View(貨品表);
        }

        // GET: 貨品表/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: 貨品表/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,貨品名稱,存貨")] 貨品表 貨品表)
        {
            if (ModelState.IsValid)
            {
                db.貨品表.Add(貨品表);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(貨品表);
        }

        // GET: 貨品表/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            貨品表 貨品表 = await db.貨品表.FindAsync(id);
            if (貨品表 == null)
            {
                return HttpNotFound();
            }
            return View(貨品表);
        }

        // POST: 貨品表/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,貨品名稱,存貨")] 貨品表 貨品表)
        {
            if (ModelState.IsValid)
            {
                db.Entry(貨品表).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(貨品表);
        }

        // GET: 貨品表/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            貨品表 貨品表 = await db.貨品表.FindAsync(id);
            if (貨品表 == null)
            {
                return HttpNotFound();
            }
            return View(貨品表);
        }

        // POST: 貨品表/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            貨品表 貨品表 = await db.貨品表.FindAsync(id);
            db.貨品表.Remove(貨品表);
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
