using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.WebUI.Areas.PrimeraVisita.Mappers;
using PodoApp.WebUI.Areas.PrimeraVisita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.PrimeraVisita.Controllers
{
    public class PrimeraVisitaController : Controller
    {
        private readonly IPacienteService _pacienteService;
        private readonly IPrimeraVisitaService _primeraVisitaService;

        public PrimeraVisitaController(IPacienteService pacienteService, IPrimeraVisitaService primeraVisitaService)
        {
            _pacienteService = pacienteService;
            _primeraVisitaService = primeraVisitaService;
        }


        // GET: PrimeraVisita
        public ActionResult Index()
        {
            return View();
        }


        // GET: /PrimeraVisita/Create
        public ActionResult Create(Guid idpaciente)
        {
            FormPrimeraVisita form = new FormPrimeraVisita();

            if (_pacienteService.Exists(idpaciente) == true)
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
        public ActionResult Create(FormPrimeraVisita form)
        {
            if (ModelState.IsValid)
            {
                _primeraVisitaService.Insert(form.FormToDTo());
                return Redirect("~/ListaPacientes/ListaPacientes/");
            }


            return View(form);
        }


        // GET: /PrimeraVisita/Edit
        public ActionResult Edit(Guid? idvisita)
        {

            if (idvisita == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PrimeraVisitaDto visita = _primeraVisitaService.Get((Guid)idvisita);

            if (visita == null)
            {
                return HttpNotFound();
            }

            FormPrimeraVisita form = visita.PrimeraVisitaDtoToFormPrimeraVisita();

            ViewBag.Podologos = new SelectList(_primeraVisitaService.GetPodologos(), "Nombre", "IdPodologo", form.IdPodologo);

            return View(form);
        }

        // POST: /PrimeraVisita/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormPrimeraVisita form)
        {
            form.IdPodologo = Guid.Parse(form.AuxIdPodolog);

            if (ModelState.IsValid)
            {
                _primeraVisitaService.Update(form.FormToDTo(false));
                return Redirect("~/ListaPacientes/ListaPacientes/");
            }
            return View(form);
        }

    }
}