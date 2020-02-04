using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment_One.Models;

namespace Assignment_One.Controllers
{
    public class Trasnaction_InfoController : Controller
    {
        private Model1 db = new Model1();

        // GET: Trasnaction_Info
        public async Task<ActionResult> Index()
        {
            return View(await db.Trasnaction_Info.ToListAsync());
        }

        // GET: Trasnaction_Info/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trasnaction_Info trasnaction_Info = await db.Trasnaction_Info.FindAsync(id);
            if (trasnaction_Info == null)
            {
                return HttpNotFound();
            }
            return View(trasnaction_Info);
        }

        // GET: Trasnaction_Info/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trasnaction_Info/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "productId,game_title,customer_name,customer_number,date_purchased,customer_payment,game_inventory,payment_confirmed")] Trasnaction_Info trasnaction_Info)
        {
            if (ModelState.IsValid)
            {
                db.Trasnaction_Info.Add(trasnaction_Info);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(trasnaction_Info);
        }

        // GET: Trasnaction_Info/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trasnaction_Info trasnaction_Info = await db.Trasnaction_Info.FindAsync(id);
            if (trasnaction_Info == null)
            {
                return HttpNotFound();
            }
            return View(trasnaction_Info);
        }

        // POST: Trasnaction_Info/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "productId,game_title,customer_name,customer_number,date_purchased,customer_payment,game_inventory,payment_confirmed")] Trasnaction_Info trasnaction_Info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trasnaction_Info).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(trasnaction_Info);
        }

        // GET: Trasnaction_Info/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trasnaction_Info trasnaction_Info = await db.Trasnaction_Info.FindAsync(id);
            if (trasnaction_Info == null)
            {
                return HttpNotFound();
            }
            return View(trasnaction_Info);
        }

        // POST: Trasnaction_Info/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            Trasnaction_Info trasnaction_Info = await db.Trasnaction_Info.FindAsync(id);
            db.Trasnaction_Info.Remove(trasnaction_Info);
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
