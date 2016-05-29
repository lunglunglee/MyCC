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
    public class C_支付方式Controller : Controller
    {
        private Model1 db = new Model1();

        // GET: C_支付方式
        public async Task<ActionResult> Index()
        {
            return View(await db.C_支付方式.ToListAsync());
        }

        // GET: C_支付方式/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_支付方式 c_支付方式 = await db.C_支付方式.FindAsync(id);
            if (c_支付方式 == null)
            {
                return HttpNotFound();
            }
            return View(c_支付方式);
        }

        // GET: C_支付方式/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: C_支付方式/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "支付方式id,支付宝,微信,NULl")] C_支付方式 c_支付方式)
        {
            if (ModelState.IsValid)
            {
                db.C_支付方式.Add(c_支付方式);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(c_支付方式);
        }

        // GET: C_支付方式/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_支付方式 c_支付方式 = await db.C_支付方式.FindAsync(id);
            if (c_支付方式 == null)
            {
                return HttpNotFound();
            }
            return View(c_支付方式);
        }

        // POST: C_支付方式/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "支付方式id,支付宝,微信,NULl")] C_支付方式 c_支付方式)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c_支付方式).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(c_支付方式);
        }

        // GET: C_支付方式/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_支付方式 c_支付方式 = await db.C_支付方式.FindAsync(id);
            if (c_支付方式 == null)
            {
                return HttpNotFound();
            }
            return View(c_支付方式);
        }

        // POST: C_支付方式/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            C_支付方式 c_支付方式 = await db.C_支付方式.FindAsync(id);
            db.C_支付方式.Remove(c_支付方式);
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
