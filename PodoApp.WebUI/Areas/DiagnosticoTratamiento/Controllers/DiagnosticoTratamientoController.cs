using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.WebUI.Areas.DiagnosticoTratamiento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PodoApp.WebUI.Areas.DiagnosticoTratamiento.Mappers;

namespace PodoApp.WebUI.Areas.DiagnosticoTratamiento.Controllers
{
    public class DiagnosticoTratamientoController : Controller
    {
        private readonly IPacienteService _pacienteService;
        private readonly IDiagnosticoTratamientoService _diagnosticoTratamientoService;

        public DiagnosticoTratamientoController(IPacienteService pacienteService, IDiagnosticoTratamientoService diagnosticoTratamientoService)
        {
            _pacienteService = pacienteService;
            _diagnosticoTratamientoService = diagnosticoTratamientoService;
        }

        // GET: /DiagnosticoTratamiento/Create
        public ActionResult Create(Guid idpaciente)
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

        // POST
        [HttpPost]
        public ActionResult Create(FormDiagnosticoTratamiento form)
        {
            //Generates a list of objects{DiagnosticoDto, MaterialSoportePlantarDto} and passes to the service
            var objects = form.FormToDto(true);
            _diagnosticoTratamientoService.Insert((DiagnosticoDto)objects[0], (MaterialSoportePlantarDto)objects[1]);
            return Redirect("~/ListaPacientes/ListaPacientes/");
        }

        // GET: /DiagnosticoTratamiento/Edit
        public ActionResult Edit(Guid? idDiagnostico)
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

        // POST: /DiagnosticoTratamiento/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormDiagnosticoTratamiento form)
        {
            if (ModelState.IsValid)
            {
                var objects = form.FormToDto();
                _diagnosticoTratamientoService.Update((DiagnosticoDto)objects[0], (MaterialSoportePlantarDto)objects[1]);
                return Redirect("~/ListaPacientes/ListaPacientes/");
            }

            return View(form);
        }


    }
}