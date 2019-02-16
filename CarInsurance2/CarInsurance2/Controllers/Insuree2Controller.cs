using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance2.Models;

namespace CarInsurance2.Controllers
{
    public class Insuree2Controller : Controller
    {
        private Insurance2Entities db = new Insurance2Entities();

        // GET: Insuree2
        public ActionResult Index()
        {
            return View(db.Insurees2.ToList());

        }
        public ActionResult Admin()
        {
            return View(db.Insurees2.ToList());
            
        }

        // GET: Insuree2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees2 insurees2 = db.Insurees2.Find(id);
            if (insurees2 == null)
            {
                return HttpNotFound();
            }
            return View(insurees2);
        }

        // GET: Insuree2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees2 insurees2)
        {
            if (ModelState.IsValid)
            {
                double CalcTotal = 50;


                int Age = (DateTime.Now.Year - insurees2.DateOfBirth.Year);



                if (Age < 25&& Age > 17)
                {
                    CalcTotal += 25;
                }
                if (Age <18)
                {
                    CalcTotal += 100;

                }

                if(Age> 100)
                {
                    CalcTotal += 25;

                }
                if (insurees2.CarYear < 2000 || insurees2.CarYear > 2015)//check if this or statement works
                {
                    CalcTotal = CalcTotal + 25;
                }

                string LowCar = insurees2.CarMake.ToLower();
                
                if (LowCar == "porsche")
                {
                    CalcTotal += 25;

                }

                if (insurees2.CarModel == "911 carrera" )
                {
                    CalcTotal += 25;

                }
                if (insurees2.SpeedingTickets >0)
                {
                    CalcTotal += (insurees2.SpeedingTickets * 10);

                }
                if (insurees2.DUI == true )
                    {
                    CalcTotal = (CalcTotal * 1.25);
                        }

                if (insurees2.CoverageType == true)
                {
                    CalcTotal = CalcTotal * 1.5;
                }
                decimal NewCalc = (decimal)CalcTotal;
                insurees2.Quote = NewCalc;

                //insurees2.FirstName 
                db.Insurees2.Add(insurees2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insurees2);
        }
      
        // GET: Insuree2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees2 insurees2 = db.Insurees2.Find(id);
            if (insurees2 == null)
            {
                return HttpNotFound();
            }
            return View(insurees2);
        }

        // POST: Insuree2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees2 insurees2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insurees2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insurees2);
        }

        // GET: Insuree2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees2 insurees2 = db.Insurees2.Find(id);
            if (insurees2 == null)
            {
                return HttpNotFound();
            }
            return View(insurees2);
        }

        // POST: Insuree2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurees2 insurees2 = db.Insurees2.Find(id);
            db.Insurees2.Remove(insurees2);
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
