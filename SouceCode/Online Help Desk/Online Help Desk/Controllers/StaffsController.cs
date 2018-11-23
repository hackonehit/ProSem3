using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Help_Desk.Models;
using System.Data.Entity;

namespace Online_Help_Desk.Controllers
{
    public class StaffsController : Controller
    {
        // GET: Staffs
        DbModel db = new DbModel();
        public ActionResult Index()
        {
            //var model = from f in db.RequestList
            //            join a in db.FacilityList on f.FacilityID equals a.FacilityID
            //            join e in db.StaffList on f.SUsername equals e.SUsername
            //            select new ViewIndexRequestHead
            //            {
            //                Request = f,
            //                Facility = a,
            //                Staff = e
            //            };
            var model = db.RequestList.ToList();
            return View(model);
        }
        public ActionResult Assign(int id)
        {
            var model = db.RequestList.SingleOrDefault(a => a.RequestID.Equals(id));
            ViewBag.FacilityList = new SelectList(db.FacilityList, "FacilityID", "FName");
            ViewBag.StaffList = new SelectList(db.StaffList, "SUsername", "Fullname");
            return View(model);
        }
        [HttpPost]
        public ActionResult Assign(Request Assign)
        {
            ViewBag.FacilityList = new SelectList(db.FacilityList, "FacilityID", "FName");
            ViewBag.StaffList = new SelectList(db.StaffList, "SUsername", "Fullname");
         //   Assign.RequestStatus = "Work In Progress";
          //  ModelState.Clear();
           
        
            if (ModelState.IsValid) 
            {

                Assign.RequestStatus = "Work in progress";
                db.Entry(Assign).State = EntityState.Modified;
                db.SaveChanges();
                ModelState.AddModelError("", "THANH CONG ROI");
                return RedirectToAction("Index", "Staffs");
            }
            else
            {
                ModelState.AddModelError("", "KO THANH CONG NHA");
            }
            return View();
        }
    }
}