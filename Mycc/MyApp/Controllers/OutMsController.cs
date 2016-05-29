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
    public class OutMsController : Controller
    {
        private Model1 db = new Model1();

        // GET: OutMs
        public async Task<ActionResult> Index()
        {
            return View(await db.OutM.ToListAsync());
        }

        // GET: OutMs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OutM outM = await db.OutM.FindAsync(id);
            if (outM == null)
            {
                return HttpNotFound();
            }
            return View(outM);
        }

        // GET: OutMs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OutMs/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,日期,貨品,紙箱,板費,快遞,輔料,其他")] OutM outM)
        {
            if (ModelState.IsValid)
            {
                db.OutM.Add(outM);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(outM);
        }

        // GET: OutMs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OutM outM = await db.OutM.FindAsync(id);
            if (outM == null)
            {
                return HttpNotFound();
            }
            return View(outM);
        }

        // POST: OutMs/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,日期,貨品,紙箱,板費,快遞,輔料,其他")] OutM outM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(outM).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(outM);
        }

        // GET: OutMs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OutM outM = await db.OutM.FindAsync(id);
            if (outM == null)
            {
                return HttpNotFound();
            }
            return View(outM);
        }

        // POST: OutMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            OutM outM = await db.OutM.FindAsync(id);
            db.OutM.Remove(outM);
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
