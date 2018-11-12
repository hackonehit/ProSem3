using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Help_Desk.Models;

namespace Online_Help_Desk.Controllers
{
    public class AdminController : Controller
    {
        DbModel db = new DbModel();
        //----Home(Admin)---------------------------
        public ActionResult Index(string U1)
        {
            ViewBag.Test = U1;
            return View(db.Admin);
        }
        //------------------------------------------
        //----Create new Staffs---------------------
        public ActionResult CreateStaff()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateStaff(Staff newStaff )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry<Staff>(newStaff).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    ModelState.AddModelError("", "Add complete!!!");
                }
                else
                {
                    ModelState.AddModelError("", "Fail");
                }
            }
            catch (Exception e)
            {

                ModelState.AddModelError("", e.Message);
            }
            return View();
        }
        //------------------------------------------
        //---Create new End-User--------------------
        public ActionResult CreateEndUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEndUser(EndUser newEndUser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry<EndUser>(newEndUser).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    ModelState.AddModelError("", "Add complete!!!");
                }
                else
                {
                    ModelState.AddModelError("", "Fail");
                }
            }
            catch (Exception e)
            {

                ModelState.AddModelError("", e.Message);
            }
            return View();
        }
        //------------------------------------------
        //----View List End-User--------------------
        [HttpGet]
        public ActionResult DetailListUser()
        {
            return View(db.UserList);
        }
        //------------------------------------------
        //----View List Staffs----------------------
        [HttpGet]
        public ActionResult DetailListStaff()
        {
            return View(db.StaffList);
        }
        //--Change Password(Admin)
        public ActionResult Edit(string id)
        {
            Admin model = db.Admin.SingleOrDefault(e => e.UserName == id);
            if (model == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Admin eAd)
        {
            try
            {
                db.Entry(eAd).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                //return RedirectToAction("Index","Admin");
                ModelState.AddModelError("", "Change Password complete!!!");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return View();
        }
        //------------------------------------------
        //----Details Information(End-User)---------
        public ActionResult DetailsInfoUser(string id)
        {
            var model = db.UserList.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult DetailsInfoUser(EndUser eUser, string id)
        {
            var model = db.UserList.SingleOrDefault(e => e.EUUserName == id);
            return View(model);
        }
        //------------------------------------------
        //----Edit Information(End-User)------------
        public ActionResult EditInforUser(string id)
        {
            EndUser model = db.UserList.SingleOrDefault(e => e.EUUserName == id);
            if (model == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult EditInforUser(EndUser eUser)
        {
            try
            {
                db.Entry(eUser).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ModelState.AddModelError("", "Edit Complete!!!");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return View();
        }
        //------------------------------------------
        //----Details Information(Staffs)-----------
        public ActionResult DetailsInfoStaffs(string id)
        {
            var model = db.StaffList.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult DetailsInfoStaffs(Staff eStaff, string id)
        {
            var model = db.StaffList.SingleOrDefault(e => e.SUserName == id);
            return View(model);
        }
        //------------------------------------------
        //----Edit Information(Staffs)--------------
        public ActionResult EditInforStaff(string id)
        {
            Staff model = db.StaffList.SingleOrDefault(e => e.SUserName == id);
            if (model == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult EditInforStaff(Staff eStaff)
        {
            try
            {
                db.Entry(eStaff).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ModelState.AddModelError("", "Edit Complete!!!");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return View();
        }
        //------------------------------------------
        //-------View List Register-----------------
        public ActionResult ViewListRegister()
        {
            return View(db.RegisterList);
        }
        //------------------------------------------
        //----Details End-User Register-------------
        public ActionResult DetailsRegister(int id)
        {
            var model = db.RegisterList.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult DetailsRegister(Register eRe, int id)
        {
            var model = db.RegisterList.SingleOrDefault(e => e.RegisterID == id);
            return View(model);
        }
        //------------------------------------------
    }
}