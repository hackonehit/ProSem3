using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Help_Desk.Models;
using System.Data.Entity;

namespace Online_Help_Desk.Controllers
{
    public class EnduserController : Controller
    {
        // GET: Enduser
        DbModel db = new DbModel();
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult EURequestList()
        {
            var model = db.RequestList.Where(p => p.EUUsername == Session["Username"].ToString());
             
            return  View(model);
        }
        public ActionResult EnduserRequest()
        {
            return View();
        }
        // GET :  EndUsers/CreateRequest
        public ActionResult CreateRequest()
        {
            return View();
        }
        // POST: EndUsers/CreateRequest
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateRequest(Request request)
        {
            if (ModelState.IsValid)
            {
                db.RequestList.Add(request);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(request);
        }



        public ActionResult EditProfile(string id)
        {
            var model = db.RequestList.SingleOrDefault(a => a.RequestID.Equals(id));
            
            return View(model);
        }
        [HttpPost]
        public ActionResult EditProfile(Request Assign)
        {
            
            if (ModelState.IsValid)
            {
                db.Entry(Assign).State = EntityState.Modified;
                db.SaveChanges();
                ModelState.AddModelError("", "THANH CONG ROI");
            }
            else
            {
                ModelState.AddModelError("", "KO THANH CONG NHA");
            }
            return View();
        }
    }
}