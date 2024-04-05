using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizGame.Controllers
{
    public class AdminController : Controller
    {
        #region AdminHomePage
        public ActionResult AdminHomePage()
        {
            return View();
        }
        #endregion

        #region AdminLogin
        public ActionResult AdminLogin()
        {
            return View();  
        }
        #endregion
    }
}