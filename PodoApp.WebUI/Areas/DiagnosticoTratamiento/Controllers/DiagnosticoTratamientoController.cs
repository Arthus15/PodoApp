using log4net;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.WebUI.Areas.DiagnosticoTratamiento.Mappers;
using PodoApp.WebUI.Areas.DiagnosticoTratamiento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.DiagnosticoTratamiento.Controllers
{
    public class DiagnosticoTratamientoController : Controller
    {
        private readonly IPacienteService _pacienteService;
        private readonly IDiagnosticoTratamientoService _diagnosticoTratamientoService;
        private readonly ILog _log;

        public DiagnosticoTratamientoController(IPacienteService pacienteService, IDiagnosticoTratamientoService diagnosticoTratamientoService, ILog log)
        {
            _pacienteService = pacienteService;
            _diagnosticoTratamientoService = diagnosticoTratamientoService;
            _log = log;
        }

        // GET: /DiagnosticoTratamiento/Create
        public ActionResult Create(Guid idpaciente)
        {
            try
            {
                PacienteDto paciente = _pacienteService.Get(idpaciente);
                FormDiagnosticoTratamiento form = new FormDiagnosticoTratamiento();

                if (paciente != null)
                {
                    form.IdPaciente = idpaciente;
                    form.IdPrimeraVisita = paciente.primeraVisita.FirstOrDefault().idPrimeraVisita;
                }
                else
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                }
                return View(form);
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Create(Guid idPaciente)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        // POST
        [HttpPost]
        public ActionResult Create(FormDiagnosticoTratamiento form)
        {
            try
            {
                //Generates a list of objects{DiagnosticoDto, MaterialSoportePlantarDto} and passes to the service
                var objects = form.FormToDto(true);
                _diagnosticoTratamientoService.Insert((DiagnosticoDto)objects[0], (MaterialSoportePlantarDto)objects[1]);
                return Redirect("~/ListaPacientes/ListaPacientes/");
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Create(FormDiagnosticoTratamiento form)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        // GET: /DiagnosticoTratamiento/Edit
        public ActionResult Edit(Guid? idDiagnostico)
        {
            try
            {
                if (idDiagnostico == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                List<object> objects = _diagnosticoTratamientoService.Get((Guid)idDiagnostico);

                if (!objects.Any())
                {
                    return HttpNotFound();
                }

                FormDiagnosticoTratamiento form = new FormDiagnosticoTratamiento((DiagnosticoDto)objects[0], (MaterialSoportePlantarDto)objects[1]);

                return View(form);
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Edit(Guid? idDiagnostico)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        // POST: /DiagnosticoTratamiento/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormDiagnosticoTratamiento form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var objects = form.FormToDto();
                    _diagnosticoTratamientoService.Update((DiagnosticoDto)objects[0], (MaterialSoportePlantarDto)objects[1]);
                    return Redirect("~/ListaPacientes/ListaPacientes/");
                }

                return View(form);
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Edit(FormDiagnosticoTratamiento form)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }


    }
}