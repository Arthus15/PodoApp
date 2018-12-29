using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.WebUI.Areas.Antecedentes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PodoApp.WebUI.Areas.Antecedentes.Mappers;

namespace PodoApp.WebUI.Areas.Antecedentes.Controllers
{
    public class AntecedentesController : Controller
    {
        private readonly IPacienteService _pacienteService;

        public AntecedentesController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        // GET: Antecedentes/Antecedentes
        public ActionResult Create(Guid idPaciente)
        {
            PacienteDto paciente = _pacienteService.Get(idPaciente);

            FormAntecedentes form = new FormAntecedentes();

            if (paciente != null)
            {
                form.IdPaciente = idPaciente;
                form.IdHistorialClinico = (Guid) paciente.id_historial_clinico;
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            return View();

        }

        public ActionResult Create(FormAntecedentes form)
        {
            if (ModelState.IsValid)
            {
                var historialMedico = form.FormToHistorialClinicoDto();
            }

            return View(form);
        }
    }
}