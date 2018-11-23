using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Online_Help_Desk.Models;

namespace Online_Help_Desk.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        
        DbModel db = new DbModel();
        
        //-------------------------------------------------
        [AllowAnonymous]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("AdminHome", "Home");
        }
    }
}