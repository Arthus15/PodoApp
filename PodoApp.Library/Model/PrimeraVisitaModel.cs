using System;
using System.Collections.Generic;

namespace PodoApp.Library.Model
{
    public class PrimeraVisitaModel
    {
        public Guid idPrimeraVisita { get; set; }
        public double? peso { get; set; }
        public double? talla { get; set; }
        public string actividadDeportiva { get; set; }
        public bool diabetes { get; set; }
        public bool alergias { get; set; }
        public string tipoAlergias { get; set; }
        public string motivoPrimeraConsulta { get; set; }
        public bool hayDolor { get; set; }
        public string dolorSitio { get; set; }
        public string dolorTipo { get; set; }
        public DateTime? fechaPrimeraConsulta { get; set; }
        public Guid? id_podologo { get; set; }
        public Guid? id_paciente { get; set; }
        public Guid? id_historial_clinico { get; set; }
        public Guid? id_tipo_estudio { get; set; }
        public Guid? id_estudio_ortopodologico { get; set; }
        public Guid? id_calzado_habitual { get; set; }

        public virtual ICollection<DiagnosticoModel> diagnostico { get; set; }
        public virtual ICollection<PruebaComplementariasModel> pruebasComplementarias { get; set; }
    }
}