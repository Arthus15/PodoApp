using log4net;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.WebUI.Areas.PrimeraVisita.Mappers;
using PodoApp.WebUI.Areas.PrimeraVisita.Models;
using System;
using System.Net;
using System.Web.Mvc;

namespace PodoApp.WebUI.Areas.PrimeraVisita.Controllers
{
    public class PrimeraVisitaController : Controller
    {
        private readonly IPacienteService _pacienteService;
        private readonly IPrimeraVisitaService _primeraVisitaService;
        private readonly ILog _log;

        public PrimeraVisitaController(IPacienteService pacienteService, IPrimeraVisitaService primeraVisitaService, ILog log)
        {
            _pacienteService = pacienteService;
            _primeraVisitaService = primeraVisitaService;
            _log = log;
        }


        // GET: PrimeraVisita
        public ActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Index()] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }


        // GET: /PrimeraVisita/Create
        public ActionResult Create(Guid idpaciente)
        {
            try
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
            catch (Exception ex)
            {
                _log.Error($"[Method: Create(Guid idPaciente)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        // POST
        [HttpPost]
        public ActionResult Create(FormPrimeraVisita form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _primeraVisitaService.Insert(form.FormToDTo());
                    return Redirect("~/ListaPacientes/ListaPacientes/");
                }

                return View(form);
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Create(FormPrimeraVisita form)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }


        // GET: /PrimeraVisita/Edit
        public ActionResult Edit(Guid? idvisita)
        {
            try
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
            catch (Exception ex)
            {
                _log.Error($"[Method: Edit(Guid? idvisita)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

        // POST: /PrimeraVisita/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormPrimeraVisita form)
        {
            try
            {
                form.IdPodologo = Guid.Parse(form.AuxIdPodolog);

                if (ModelState.IsValid)
                {
                    _primeraVisitaService.Update(form.FormToDTo(false));
                    return Redirect("~/ListaPacientes/ListaPacientes/");
                }
                return View(form);
            }
            catch (Exception ex)
            {
                _log.Error($"[Method: Edit(FormPrimeraVisita form)] -> {ex}");

                return Redirect("~/Error/Error");
            }
        }

    }
}