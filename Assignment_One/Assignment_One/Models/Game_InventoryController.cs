﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Assignment_One.Models
{
    public class Game_InventoryController : Controller
    {
        private Model1 db = new Model1();

        // GET: Game_Inventory
        public ActionResult Index()
        {
            return View(db.Game_Inventory.ToList());
        }

        // GET: Game_Inventory/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game_Inventory game_Inventory = db.Game_Inventory.Find(id);
            if (game_Inventory == null)
            {
                return HttpNotFound();
            }
            return View(game_Inventory);
        }

        // GET: Game_Inventory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Game_Inventory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "productId,game_title,game_genre,age_restiction_rating,date_release,game_owners,game_ratings,in_Stock,game_price,modable_game,type_of_game")] Game_Inventory game_Inventory)
        {
            if (ModelState.IsValid)
            {
                db.Game_Inventory.Add(game_Inventory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(game_Inventory);
        }

        // GET: Game_Inventory/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game_Inventory game_Inventory = db.Game_Inventory.Find(id);
            if (game_Inventory == null)
            {
                return HttpNotFound();
            }
            return View(game_Inventory);
        }

        // POST: Game_Inventory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "productId,game_title,game_genre,age_restiction_rating,date_release,game_owners,game_ratings,in_Stock,game_price,modable_game,type_of_game")] Game_Inventory game_Inventory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(game_Inventory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(game_Inventory);
        }

        // GET: Game_Inventory/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game_Inventory game_Inventory = db.Game_Inventory.Find(id);
            if (game_Inventory == null)
            {
                return HttpNotFound();
            }
            return View(game_Inventory);
        }

        // POST: Game_Inventory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Game_Inventory game_Inventory = db.Game_Inventory.Find(id);
            db.Game_Inventory.Remove(game_Inventory);
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
