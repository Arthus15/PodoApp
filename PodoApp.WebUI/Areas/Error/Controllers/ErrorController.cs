using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.Error.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error/Error
        public ActionResult Error_500()
        {
            return View();
        }
    }
}