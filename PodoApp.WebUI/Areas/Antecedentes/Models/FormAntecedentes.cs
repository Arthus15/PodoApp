using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.Antecedentes.Models
{
    public class FormAntecedentes
    {
        public Guid IdPaciente { get; set; }

        // Historial Clinico

        [Required()]
        public Guid IdHistorialClinico { get; set; }



        public Guid? IdAntPodologicos { get; set; }
        public Guid? IdAntFisiologicos { get; set; }
        public Guid? IdAntPatologicos { get; set; }
        public Guid? IdAntFamiliares { get; set; }

        // ANTECEDENTES PODOLÓGICOS

        [DisplayName("¿Ha ido al podólogo anteriormente?")]
        [Required()]
        public bool HaIdoPodologo { get; set; }

        [DisplayName("Antecedentes ")]
        public string Antecedentes { get; set; }

        // ANTECEDENTES PATOLÓGICOS

        [DisplayName("Patología previa ")]
        public string PatologiaPrevia { get; set; }

        [DisplayName("Enfermedad infantil ")]
        public string EnfermedadInfantil { get; set; }

        [DisplayName("Antecedentes traumáticos")]
        public string AntecedentesTraumaticos { get; set; }

        [DisplayName("Bursistis")]
        public bool Bursitis { get; set; }

        [DisplayName("Capsulitis")]
        public bool Capsulitis { get; set; }

        [DisplayName("Enfermedad reumática")]
        public bool EnfermedadReumatica { get; set; }

        [DisplayName("Tipo enfermedad reumática")]
        public string TipoEnfermedadReumatica { get; set; }

        [DisplayName("Ciática")]
        public bool Ciatica { get; set; }

        [DisplayName("Otros")]
        public string OtrosPatologico { get; set; }

        [DisplayName("Distensión")]
        public bool Distension { get; set; }

        [DisplayName("Esguince")]
        public bool Esguince { get; set; }

        [DisplayName("Tendinitis")]
        public bool Tendinitis { get; set; }

        [DisplayName("Contracturas")]
        public bool Contracturas { get; set; }

        [DisplayName("Luxación")]
        public bool Luxacion { get; set; }

        [DisplayName("Subluxación")]
        public bool Subluxacion { get; set; }

        [DisplayName("Fisura")]
        public bool Fisura { get; set; }

        [DisplayName("Fractura")]
        public bool Fractura { get; set; }

        // ANTECEDENTES FISIOLÓGICOS

        [DisplayName("Andador")]
        public bool Andador { get; set; }

        [DisplayName("Tacata")]
        public bool Tacata { get; set; }

        [DisplayName("Inicio Deambulación")]
        public int? InicioDeambulacion { get; set; }

        [DisplayName("Hábitos Posturales")]
        public string HabitosPosturales { get; set; }

        [DisplayName("Cambios Ponderales")]
        public int? CambiosPonderales { get; set; }

        [DisplayName("Zurdo")]
        public bool Zurdo { get; set; }

        [DisplayName("Diestro")]
        public bool Diestro { get; set; }

        [DisplayName("Ambidiestro")]
        public bool Ambidiestro { get; set; }

        [DisplayName("Parto de cabeza")]
        public bool PartoCabeza { get; set; }

        [DisplayName("Parto de nalgas")]
        public bool PartoNalgas { get; set; }

        [DisplayName("Otros")]
        public string OtrosFisiologico { get; set; }

        // ANTECEDENTES FAMILIARES

        [DisplayName("Dismetrías")]
        public bool Dismetrias { get; set; }

        [DisplayName("Escoliosis")]
        public bool Escoliosis { get; set; }

        [DisplayName("Tibias Varas")]
        public bool TibiasVaras { get; set; }

        [DisplayName("Pies planos")]
        public bool PiesPlanos { get; set; }

        [DisplayName("Pies cavos")]
        public bool PiesCavos { get; set; }

        [DisplayName("Pies valgos")]
        public bool PiesValgos { get; set; }

        [DisplayName("Pies zambos")]
        public bool PiesZambos { get; set; }

        [DisplayName("Hallus Valgus")]
        public bool HallusValgus { get; set; }

        [DisplayName("Dedos garra")]
        public bool DedosGarra { get; set; }

        [DisplayName("Genu Varo")]
        public bool GenuVaro { get; set; }

        [DisplayName("Genu Valgo")]
        public bool GenuValgo { get; set; }

        [DisplayName("Meta Aductus")]
        public bool MetaAductus { get; set; }

        [DisplayName("Meta Varus")]
        public bool MetaVarus { get; set; }

        [DisplayName("Otros")]
        public string OtrosFamiliares { get; set; }
    }
}