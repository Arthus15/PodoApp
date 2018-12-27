using PodoApp.Contracts.ServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PodoApp.WebUI.Areas.ListaPacientes.Mappers;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.WebUI.Areas.ListaPacientes.Models;

namespace PodoApp.WebUI.Areas.ListaPacientes.Controllers
{
    public class ListaPacientesController : Controller
    {
        private readonly IListaPacienteService _pacienteService;

        public ListaPacientesController(IListaPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        // GET: ListaPacientes
        public ActionResult Index()
        {
            IEnumerable<PacienteDto> pacientes = _pacienteService.GetAll();
            List<PacienteViewModel> pacientesViewModel = pacientes.Select(x => x.DtoToViewModel()).ToList();
            return View(pacientesViewModel);
        }
    }
}