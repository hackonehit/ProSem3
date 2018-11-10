using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Help_Desk.Models;

namespace Online_Help_Desk.Controllers
{
    public class HomeController : Controller
    {
        DbModel db = new DbModel();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Admin);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Admin newAdmin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry<Admin>(newAdmin).State = System.Data.Entity.EntityState.Added;
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
    }
}