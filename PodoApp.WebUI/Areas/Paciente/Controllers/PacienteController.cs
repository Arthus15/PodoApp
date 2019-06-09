using log4net;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.WebUI.Areas.Paciente.Mappers;
using PodoApp.WebUI.Areas.Paciente.Models;
using System;
using System.Net;
using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.Paciente.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacienteService _pacienteService;
        private readonly ILog _log;

        public PacienteController(IPacienteService pacienteService, ILog log)
        {
            _pacienteService = pacienteService;
            _log = log;
        }

        // GET: Paciente/Paciente
        public ActionResult Create()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Create()] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        [HttpPost]
        public ActionResult Create(FormPaciente form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _pacienteService.Insert(form.FormPacientToDto());
                    return Redirect("~/ListaPacientes/ListaPacientes/");
                }
                return View();
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Create(FormPaciente form)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        // GET: /Paciente/Edit
        public ActionResult Edit(Guid? idpaciente)
        {
            try
            {
                if (idpaciente == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var paciente = _pacienteService.Get((Guid)idpaciente);

                if (paciente == null)
                {
                    return HttpNotFound();
                }

                return View(paciente.PacienteDtoToFormPaciente());
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Edit(Guid? idpaciente)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        // POST: /Paciente/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormPaciente form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _pacienteService.Update(form.FormPacientToDto());
                    return Redirect("~/ListaPacientes/ListaPacientes/");
                }
                return View(form);
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Edit(FormPaciente form)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }
    }
}