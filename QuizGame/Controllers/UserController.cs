using System.Web.Mvc;
using Quiz.BAL.IAgent;
using QuizViewModel;
using System.Web.Security;

namespace QuizGame.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserAgent _userAgent; 

        public UserController(IUserAgent userAgent)
        {
            _userAgent = userAgent;
        }

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {  
            if (_userAgent.AuthenticateUser(loginViewModel))
            {
                FormsAuthentication.SetAuthCookie(loginViewModel.EmailAddress, false);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Invalid Email and Password");
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(SignUpViewModel signUpViewModel)
        {
            if (ModelState.IsValid)
            {
                _userAgent.CreateUser(signUpViewModel);
                return RedirectToAction("Login");
            }
            return View(signUpViewModel);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
