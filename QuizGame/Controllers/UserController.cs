using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizGame.Controllers
{
    public class UserController : Controller
    {
        #region UserHomePage
        public ActionResult UserHomePage()
        {
            return View();
        }
        #endregion

        #region UserLogin
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        #endregion

        #region UserSignIn
        public ActionResult SignIn()
        {
            return View();
        }
        #endregion

    }
}

