using log4net;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using PodoApp.DB.Infrastructure.Configuration.Owin;
using PodoApp.Impl.ServiceLibrary.Configuration.Owin;
using PodoApp.WebUI.Areas.Login.Models;
using System;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.Login.Controllers
{
    public class LoginController : Controller
    {

        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private readonly ILog _log;

        public LoginController(ILog log)
        {
            _log = log;
        }

        public LoginController(ApplicationUserManager userManager, ApplicationSignInManager signInManager, ILog log)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            _log = log;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET: Login/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Login()] -> {ex} ");

                return Redirect("~/Error/Error");
            }

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model, string returnUrl)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, change to shouldLockout: true
                var result = await
                SignInManager.PasswordSignInAsync(model.Usuario, model.Password, true, shouldLockout: false);
                switch (result)
                {
                    case SignInStatus.Success:
                        return Redirect("~/Dashboard/Dashboard/Dashboard_v1");
                    case SignInStatus.LockedOut:
                        return View("Lockout");
                    case SignInStatus.RequiresVerification:
                        return RedirectToAction("SendCode", new
                        {
                            ReturnUrl = returnUrl,
                            RememberMe = true
                        });
                    case SignInStatus.Failure:
                    default:
                        ModelState.AddModelError("", "Invalid login attempt.");
                        return View(model);
                }
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Login(LoginModel model, string returnUrl)] -> {ex} ");

                return Redirect("~/Error/Error");
            }
        }

        // GET: /Pages/LogOff

        public ActionResult LogOff()
        {
            try
            {
                IAuthenticationManager AuthenticationManager = HttpContext.GetOwinContext().Authentication;
                AuthenticationManager.SignOut();

                return Redirect("~/Login/Login");
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: LogOff()] -> {ex} ");

                return Redirect("~/Error/Error");
            }
        }
    }
}