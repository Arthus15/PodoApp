using log4net;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.WebUI.Areas.Consulta.Mapper;
using PodoApp.WebUI.Areas.Consulta.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.Consulta.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly IPacienteService _pacienteService;
        private readonly IPrimeraVisitaService _primeraVisitaService;
        private readonly IConsultaService _consultaService;
        private readonly ILog _log;

        public ConsultaController(IPacienteService pacienteService, IPrimeraVisitaService primeraVisitaService,
                                  IConsultaService consultaService, ILog log)
        {
            _pacienteService = pacienteService;
            _primeraVisitaService = primeraVisitaService;
            _consultaService = consultaService;
            _log = log;
        }

        public ActionResult Index(Guid idpaciente)
        {
            try
            {
                ViewBag.paciente = new SelectList(new List<PacienteDto>() { _pacienteService.Get(idpaciente) }, "idPaciente", "idPaciente");

                return View(_consultaService.GetAllByPacienteId(idpaciente));
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Index(Guid idpaciente)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        // GET: /Consulta/Create
        public ActionResult Create(Guid idpaciente)
        {
            try
            {
                PacienteDto paciente = _pacienteService.Get(idpaciente);

                FormConsulta form = new FormConsulta();

                if (paciente != null)
                {
                    form.IdPaciente = idpaciente;
                }
                else
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                }

                ViewBag.Podologos = new SelectList(_primeraVisitaService.GetPodologos(), "Nombre", "IdPodologo");

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
        public ActionResult Create(FormConsulta form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PacienteDto paciente = _pacienteService.Get((Guid)form.IdPaciente);
                    _consultaService.Insert(form.FormConsultaToDto());
                    return Redirect("~/ListaPacientes/ListaPacientes/");
                }
                return View(form);
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Create(FormConsulta form)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        // GET: /Consulta/Edit
        public ActionResult Edit(Guid? idConsulta)
        {
            try
            {
                if (idConsulta == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                ConsultaDto consulta = _consultaService.Get((Guid)idConsulta);

                if (consulta == null)
                {
                    return HttpNotFound();
                }
                FormConsulta form = consulta.DtoToFormConsulta();

                ViewBag.Podologos = new SelectList(_primeraVisitaService.GetPodologos(), "Nombre", "IdPodologo", form.IdPodologo);

                return View(form);
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Edit(Guid? idConsulta)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        // POST: /Consulta/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormConsulta form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _consultaService.Update(form.FormConsultaToDto(false));
                    return Redirect("~/ListaPacientes/ListaPacientes/");
                }
                return View(form);
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Edit(FormConsulta form)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }


        // GET: /Consulta/Select
        public ActionResult Select(Guid idpaciente)
        {
            try
            {
                PacienteDto paciente = _pacienteService.Get(idpaciente);
                FormConsulta form = new FormConsulta();

                if (paciente != null)
                {
                    form.IdPaciente = idpaciente;
                }
                else
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                }
                return View();
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Select(Guid idpaciente)] -> {ex}");

                return Redirect("~/Error/Error");
            }

        }

        // POST
        [HttpPost]
        public ActionResult Select(FormConsulta form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Select", "Consulta");
                }
                return View(form);
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Select(FormConsulta form)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

    }
}