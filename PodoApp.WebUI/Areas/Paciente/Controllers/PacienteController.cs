using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.WebUI.Areas.Paciente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PodoApp.WebUI.Areas.Paciente.Mappers;
using System.Net;

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
                _pacienteService.Insert(form.FormPacientToDto());
                return Redirect("~/ListaPacientes/ListaPacientes/");
            }
            return View();
        }

        // GET: /Paciente/Edit
        public ActionResult Edit(Guid? idpaciente)
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

        // POST: /Paciente/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormPaciente form)
        {
            if (ModelState.IsValid)
            {
                _pacienteService.Update(form.FormPacientToDto());
                return Redirect("~/ListaPacientes/ListaPacientes/");
            }
            return View(form);
        }
    }
}