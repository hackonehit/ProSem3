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
            return View();
        }
        
    }
}