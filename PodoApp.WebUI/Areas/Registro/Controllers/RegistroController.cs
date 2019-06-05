using Microsoft.AspNet.Identity.Owin;
using PodoApp.DB.Infrastructure.Configuration.Owin;
using PodoApp.Impl.ServiceLibrary.Configuration.Owin;
using PodoApp.WebUI.Areas.Registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.Registro.Controllers
{
    public class RegistroController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;


        #region Constructor
        public RegistroController()
        {
        }

        public RegistroController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
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

        #endregion

        [Authorize(Roles = "ADMIN")]
        //[AllowAnonymous]
        public ActionResult Registro()
        {
            return View();
        }
        public ActionResult Recover()
        {
            return View();
        }

        //
        // POST: /Pages/Register
        [HttpPost]
        [Authorize(Roles = "ADMIN")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Registro(RegistroModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Usuario, Email = model.Usuario + "@uma.es" };
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    return Redirect("~/Dashboard/Dashboard/Dashboard_v1"); ;
                }
            }

            return View(model);
        }
    }
}