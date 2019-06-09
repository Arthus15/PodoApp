using log4net;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.WebUI.Areas.ListaPacientes.Mappers;
using PodoApp.WebUI.Areas.ListaPacientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.ListaPacientes.Controllers
{
    public class ListaPacientesController : Controller
    {
        private readonly IListaPacienteService _pacienteService;
        private readonly ILog _log;

        public ListaPacientesController(IListaPacienteService pacienteService, ILog log)
        {
            _pacienteService = pacienteService;
            _log = log;
        }

        // GET: ListaPacientes
        public ActionResult Index()
        {
            try
            {
                IEnumerable<PacienteDto> pacientes = _pacienteService.GetAll();
                List<PacienteViewModel> pacientesViewModel = pacientes.Select(x => x.DtoToViewModel()).ToList();
                return View(pacientesViewModel);
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Index()] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }
    }
}