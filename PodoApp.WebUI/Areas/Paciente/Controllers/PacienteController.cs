using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.WebUI.Areas.Paciente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PodoApp.WebUI.Areas.Paciente.Mappers;

namespace PodoApp.WebUI.Areas.Paciente.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacienteService _pacienteService;

        public PacienteController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        // GET: Paciente/Paciente
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormPaciente form)
        {
            if (ModelState.IsValid)
            {
                _pacienteService.InsertPacient(form.FormPacientToDto());
                return Redirect("~/ListaPacientes/ListaPacientes/");
            }
            return View();
        }
    }
}