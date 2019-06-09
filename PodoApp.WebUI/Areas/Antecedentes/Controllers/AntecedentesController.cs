using log4net;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.WebUI.Areas.Antecedentes.Mappers;
using PodoApp.WebUI.Areas.Antecedentes.Models;
using System;
using System.Net;
using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.Antecedentes.Controllers
{
    public class AntecedentesController : Controller
    {
        private readonly IPacienteService _pacienteService;
        private readonly IAntecedentesService _antecedentesService;
        private readonly ILog _log;

        public AntecedentesController(IPacienteService pacienteService, IAntecedentesService antecedentesService, ILog log)
        {
            _pacienteService = pacienteService;
            _antecedentesService = antecedentesService;
            _log = log;
        }

        // GET: Antecedentes/Antecedentes
        [HttpGet]
        public ActionResult Create(Guid idPaciente)
        {
            try
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
            catch (Exception ex)
            {
                _log.Error($"[Method: Create(Guid idPaciente)] -> {ex}");

                return Redirect("~/Error/Error");
            }

        }

        [HttpPost]
        public ActionResult Create(FormAntecedentes form)
        {
            try
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
            catch (Exception ex)
            {
                _log.Error($"[Method: Create(FormAntecedentes form)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        public ActionResult Edit(Guid? idPaciente)
        {
            try
            {
                if (idPaciente == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var paciente = _pacienteService.Get((Guid)idPaciente);

                var historial = paciente.historialClinico;

                if (historial == null)
                {
                    return HttpNotFound();
                }

                return View(historial.FillForm());
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Edit(Guid? idPaciente)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        // POST: /Antecedentes/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormAntecedentes form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _antecedentesService.Update(form.FormToHistorialClinicoDto(false));
                    return Redirect("~/ListaPacientes/ListaPacientes/");
                }
                return View(form);
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Edit(FormAntecedentes form)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }
    }
}