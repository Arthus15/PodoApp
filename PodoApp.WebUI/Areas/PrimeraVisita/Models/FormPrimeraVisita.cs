using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.PrimeraVisita.Models
{
    public class FormPrimeraVisita
    {
        public Guid IdPaciente { get; set; }

        // Primera Visita

        [Required()]
        public Guid IdPrimeraVisita { get; set; }

        [DisplayName("Peso")]
        public double? Peso { get; set; }

        [DisplayName("Altura")]
        public double? Altura { get; set; }

        [DisplayName("Actividad deportiva que realiza")]
        public string ActividadDeportiva { get; set; }

        [DisplayName("Diabetes")]
        public bool Diabetes { get; set; }

        [DisplayName("Alergias")]
        public bool Alergias { get; set; }

        [DisplayName("Tipo de alergia")]
        public string TipoAlergia { get; set; }

        [DisplayName("Motivo Primera Consulta")]
        public string MotivoPrimeraConsulta { get; set; }

        [DisplayName("¿Hay dolor?")]
        public bool HayDolor { get; set; }

        [DisplayName("Zona del dolor")]
        public string ZonaDolor { get; set; }

        [DisplayName("Tipo de dolor")]
        public string TipoDolor { get; set; }

        [DisplayName("Fecha primera consulta")]
        public DateTime? FechaPrimeraConsulta { get; set; }

        // Calzado Habitual

        public Guid? IdCalzado { get; set; }

        [DisplayName("Deportivos")]
        public bool Deportivos { get; set; }

        [DisplayName("Vestir")]
        public bool Vestir { get; set; }

        [DisplayName("Sandalias")]
        public bool Sandalias { get; set; }

        [DisplayName("Botines")]
        public bool Botines { get; set; }

        [DisplayName("Tacones")]
        public bool Tacones { get; set; }

        // podologo

        public Guid? IdPodologo { get; set; }

        public string IdTitulo { get; set; }

        public string Email { get; set; }

        //Var used to assign value from ddl
        public string AuxIdPodolog { get; set; }

    }
}