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

            
            var model = new LoginResgisterView();
            model.Enduser = new Enduser();
            model.Register = new Register();
            return View(model);
        }
        public ActionResult EUHome()
        {
            var model = new LoginResgisterView();
            model.Enduser = new Enduser();
            model.Register = new Register();
            return View(model);
        }
        public ActionResult EnduserHome()
        {
            Session["Login"] = "NotYet";
            return RedirectToAction("EUHome");
        }
        public ActionResult StaffHome()
        {
            Session["Login"] = "NotYet";
            return RedirectToAction("StaffLogin");
        }
        
        public ActionResult AdminLogin()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin AdLogin)
        {
            try
            {

                var model = db.Admin.Single(p => p.UserName == AdLogin.UserName && p.Password == AdLogin.Password);
                if (model != null)
                {
                    Session["UserName"] = model.UserName.ToString();
                    return RedirectToAction("Index", "Admin");
                }
                
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }

            
            Session["Login"] = "LoginSuccess";
            return RedirectToAction("Index", "Home");
        }
        public ActionResult StaffLogin()
        {

            return View();
        }
        [HttpPost]
        public ActionResult StaffLogin(Staff SLogin)
        {
            try
            {

                var model = db.StaffList.Single(p => p.SUsername == SLogin.SUsername && p.SPassword == SLogin.SPassword);

                Session["UserName"] = model.SUsername.ToString();


                if (model != null)
                {
                    if (model.Status == true)
                    {
                        return RedirectToAction("Index", "Staff");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Your account has been locked, please contact admin to unlock!!!");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The account or password is incorrect, please re-enter!!!");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("StaffLogin","Home");
        }

        public ActionResult UserLogin()
        {

            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(Enduser ULogin)
        {
            try
            {

                var model = db.UserList.Single(p => p.EUUsername == ULogin.EUUsername && p.EUPassword == ULogin.EUPassword);

               


                if (model != null)
                {
                    Session["UserName"] = model.EUUsername.ToString();
                    if (model.EUStatus == true)
                    {
                        return RedirectToAction("Index", "Enduser");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Your account has been locked, please contact admin to unlock!!!");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The account or password is incorrect, please re-enter!!!");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            Session["Login"] = "LoginSuccess";
            return RedirectToAction("EUHome","Home");
        }

    }
}