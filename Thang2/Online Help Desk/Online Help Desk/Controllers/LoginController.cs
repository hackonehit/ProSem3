using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Help_Desk.Models;

namespace Online_Help_Desk.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DbModel db = new DbModel();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin AdLogin, Staff stlogin)
        {
            try
            {
                var model = db.Admin.Single(p => p.UserName == AdLogin.UserName && p.Password == AdLogin.Password);
                if (model != null)
                {
                    Session["UserName"] = model.UserName.ToString();
                    return RedirectToAction("Index","Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Tk or MK sai");
                }
                //-------------------------------------------------
                var model1 = db.StaffList.Single(p => p.SUserName == stlogin.SUserName && p.SPassword == stlogin.SPassword);
                if (model1 != null)
                {
                    Session["SUserName"] = model1.SUserName.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Tk or MK sai");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if (Session["SUserName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
            
        }
        [AllowAnonymous]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Login");
        }
    }
}