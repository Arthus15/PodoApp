using PodoApp.Contracts.ServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PodoApp.WebUI.Areas.ListaPacientes.Mappers;

namespace PodoApp.WebUI.Areas.ListaPacientes.Controllers
{
    public class ListaPacientesController : Controller
    {
        private readonly IPacienteService _pacienteService;

        public ListaPacientesController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        // GET: ListaPacientes
        public ActionResult Index()
        {
            var pacientes = _pacienteService.GetAll().ToList();
            var pacientesViewModel = pacientes.Select(x => x.DtoToViewModel());
            return View(pacientesViewModel.ToList());
        }
    }
}