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
        public ActionResult Index()
        {
            if (Session["UserName"]!=null)
            {
                return View(db.Admin);
            }
            else
            {
                
                return RedirectToAction("Index", "Home");
            }
           
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
        public ActionResult CreateEndUser(Enduser newEndUser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry<Enduser>(newEndUser).State = System.Data.Entity.EntityState.Added;
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
        public ActionResult DetailListStaff(string sName)
        {
            var model = db.StaffList.ToList();
            if (!string.IsNullOrEmpty(sName))
            {
                model = model.Where(p => p.SUsername.Contains(sName)).ToList();
                return View(model);
            }
            else
            {
                return View(model);
            }
        }
        //--Change Password(Admin)
        public ActionResult Edit(string id)
        {
            Admin model = db.Admin.SingleOrDefault(e => e.UserName =="admin");
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
        public ActionResult DetailsInfoUser(Enduser eUser, string id)
        {
            var model = db.UserList.SingleOrDefault(e => e.EUUsername == id);
            return View(model);
        }
        //------------------------------------------
        //----Edit Information(End-User)------------
        public ActionResult EditInforUser(string id)
        {
            Enduser model = db.UserList.SingleOrDefault(e => e.EUUsername == id);
            if (model == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult EditInforUser(Enduser eUser)
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
            var model = db.StaffList.SingleOrDefault(e => e.SUsername == id);
            return View(model);
        }
        //------------------------------------------
        //----Edit Information(Staffs)--------------
        public ActionResult EditInforStaff(string id)
        {
            Staff model = db.StaffList.SingleOrDefault(e => e.SUsername == id);
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
        public ActionResult BlockStaff(string id)
        {
            //var player = db.CarList.Find(id);
            Staff model = db.StaffList.Find(id);
            if (model == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            else
            {
                model.Status = false;
                db.SaveChanges();
                
                return RedirectToAction("DetaiListStaff", "Admin");
            }
            
        }
        //[HttpPost]
        //public ActionResult BlockStaff(Staff eStaff)
        //{
        //    try
        //    {
                
        //        eStaff.Status =false;
        //        db.SaveChanges();
        //        ModelState.AddModelError("", "Bock Complete!!!");
        //        return RedirectToAction("DetaiListStaff","Admin");
        //    }
        //    catch (Exception e)
        //    {
        //        ModelState.AddModelError("", e.Message);
        //    }
        //    return View();
        //}
    }
}