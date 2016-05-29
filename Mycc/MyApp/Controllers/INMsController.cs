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
    public class INMsController : Controller
    {
        private Model1 db = new Model1();

        // GET: INMs
        public async Task<ActionResult> Index()
        {
            var iNM = db.INM.Include(i => i.C_代理).Include(i => i.C_貨品);
            return View(await iNM.ToListAsync());
        }

        // GET: INMs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INM iNM = await db.INM.FindAsync(id);
            if (iNM == null)
            {
                return HttpNotFound();
            }
            return View(iNM);
        }

        // GET: INMs/Create
        public ActionResult Create()
        {
            ViewBag.代理 = new SelectList(db.C_代理, "代理名稱", "代理名稱");
            ViewBag.產品 = new SelectList(db.C_貨品, "貨品名稱", "貨品名稱");
            return View();
        }

        // POST: INMs/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,日期,代理,支付方式,產品,數量,價格,已發貨")] INM iNM)
        {
            if (ModelState.IsValid)
            {
                db.INM.Add(iNM);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.代理 = new SelectList(db.C_代理, "代理名稱", "代理名稱", iNM.代理);
            ViewBag.產品 = new SelectList(db.C_貨品, "貨品名稱", "貨品名稱", iNM.產品);
            return View(iNM);
        }

        // GET: INMs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INM iNM = await db.INM.FindAsync(id);
            if (iNM == null)
            {
                return HttpNotFound();
            }
            ViewBag.代理 = new SelectList(db.C_代理, "代理名稱", "代理名稱", iNM.代理);
            ViewBag.產品 = new SelectList(db.C_貨品, "貨品名稱", "貨品名稱", iNM.產品);
            return View(iNM);
        }

        // POST: INMs/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,日期,代理,支付方式,產品,數量,價格,已發貨")] INM iNM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iNM).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.代理 = new SelectList(db.C_代理, "代理名稱", "代理名稱", iNM.代理);
            ViewBag.產品 = new SelectList(db.C_貨品, "貨品名稱", "貨品名稱", iNM.產品);
            return View(iNM);
        }

        // GET: INMs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INM iNM = await db.INM.FindAsync(id);
            if (iNM == null)
            {
                return HttpNotFound();
            }
            return View(iNM);
        }

        // POST: INMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            INM iNM = await db.INM.FindAsync(id);
            db.INM.Remove(iNM);
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
