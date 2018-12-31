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
        private readonly IAntecedentesService _antecedentesService;

        public AntecedentesController(IPacienteService pacienteService, IAntecedentesService antecedentesService)
        {
            _pacienteService = pacienteService;
            _antecedentesService = antecedentesService;
        }

        // GET: Antecedentes/Antecedentes
        [HttpGet]
        public ActionResult Create(Guid idPaciente)
        {
            PacienteDto paciente = _pacienteService.Get(idPaciente);

            FormAntecedentes form = new FormAntecedentes();

            if (paciente != null)
            {
                form.IdPaciente = idPaciente;
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            return View();

        }

        [HttpPost]
        public ActionResult Create(FormAntecedentes form)
        {
            if (ModelState.IsValid)
            {
                var paciente = _pacienteService.Get(form.IdPaciente);
                form.IdHistorialClinico = paciente.historialClinico.idHistorialClinico;
                var historialClinico = form.FormToHistorialClinicoDto();
                _antecedentesService.Insert(historialClinico);
            }

            return View(form);
        }

        public ActionResult Edit(Guid? idPaciente)
        {
            if (idPaciente == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var paciente = _pacienteService.Get((Guid) idPaciente);

            var historial = paciente.historialClinico;

            if (historial == null)
            {
                return HttpNotFound();
            }            

            return View(historial.FillForm());
        }

        // POST: /Antecedentes/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormAntecedentes form)
        {
            if (ModelState.IsValid)
            {
                _antecedentesService.Update(form.FormToHistorialClinicoDto(false));
                return Redirect("~/ListaPacientes/ListaPacientes/");
            }
            return View(form);
        }
    }
}