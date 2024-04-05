using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizGame.Controllers
{
    public class HomeController : Controller
    {
        #region LandingPage
        public ActionResult LandingPage()
        {
            return View();
        }
        #endregion

        #region UserLogout
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        #endregion
    }
}