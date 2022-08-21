using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u21441104_HW_04.Controllers
{
    public class CreateProfileController : Controller
    {
        // GET: CreateProfile
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string numID, string txtPassword)
        {
            if (numID == null)
            {
                numID = "q";
            }
            ViewBag.Hello = numID + " " + txtPassword;
            return View();
        }

    }
}