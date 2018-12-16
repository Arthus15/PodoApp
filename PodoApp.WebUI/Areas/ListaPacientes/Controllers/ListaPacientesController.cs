using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.ListaPacientes.Controllers
{
    public class ListaPacientesController : Controller
    {
        // GET: ListaPacientes
        public ActionResult Index()
        {
            return View();
        }
    }
}