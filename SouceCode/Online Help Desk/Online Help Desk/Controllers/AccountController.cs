using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Help_Desk.Models;

namespace Online_Help_Desk.Controllers
{
    public class AccountController : Controller
    {
        DbModel db = new DbModel();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Register()
        {
            return RedirectToAction("Index","Home");
        }
        [HttpPost]
        public ActionResult Register(Register newR, FormCollection co)
        {
            try
            {
                //string gender = co["optradio"];
                //newR.Gender = gender;
                if (ModelState.IsValid)
                {
                    db.Entry<Register>(newR).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                   
                }
              
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index","Home");
        }
    }
}