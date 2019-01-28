using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.WebUI.Areas.Consulta.Mapper;
using PodoApp.WebUI.Areas.Consulta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.Consulta.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly IPacienteService _pacienteService;
        private readonly IPrimeraVisitaService _primeraVisitaService;
        private readonly IConsultaService _consultaService;

        public ConsultaController(IPacienteService pacienteService, IPrimeraVisitaService primeraVisitaService, IConsultaService consultaService)
        {
            _pacienteService = pacienteService;
            _primeraVisitaService = primeraVisitaService;
            _consultaService = consultaService;
        }

        public ActionResult Index(Guid idpaciente)
        {
            ViewBag.paciente = new SelectList(new List<PacienteDto>() { _pacienteService.Get(idpaciente) }, "idPaciente", "idPaciente");

            return View(_consultaService.GetAllByPacienteId(idpaciente));
        }

        // GET: /Consulta/Create
        public ActionResult Create(Guid idpaciente)
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

        // POST
        [HttpPost]
        public ActionResult Create(FormConsulta form)
        {
            if (ModelState.IsValid)
            {
                PacienteDto paciente = _pacienteService.Get((Guid)form.IdPaciente);
                _consultaService.Insert(form.FormConsultaToDto());
                return Redirect("~/ListaPacientes/ListaPacientes/");
            }
            return View(form);
        }

        // GET: /Consulta/Edit
        public ActionResult Edit(Guid? idConsulta)
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

            ViewBag.Podologos = new SelectList(_primeraVisitaService.GetPodologos(), "Nombre", "IdPodologo",form.IdPodologo);

            return View(form);
        }

        // POST: /Consulta/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormConsulta form)
        {
            if (ModelState.IsValid)
            {
                _consultaService.Update(form.FormConsultaToDto(false));
                return Redirect("~/ListaPacientes/ListaPacientes/");
            }
            return View(form);
        }


        // GET: /Consulta/Select
        public ActionResult Select(Guid idpaciente)
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

        // POST
        [HttpPost]
        public ActionResult Select(FormConsulta form)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Select", "Consulta");
            }
            return View(form);
        }

    }
}