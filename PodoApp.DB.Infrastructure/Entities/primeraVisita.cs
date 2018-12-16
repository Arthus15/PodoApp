namespace PodoApp.DB.Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("primeraVisita")]
    public partial class PrimeraVisita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrimeraVisita()
        {
            diagnostico = new HashSet<Diagnostico>();
            pruebasComplementarias = new HashSet<PruebasComplementarias>();
        }

        [Key]
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

        public virtual CalzadoHabitual calzadoHabitual { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnostico> diagnostico { get; set; }

        public virtual EstudioOrtopodologico estudioOrtopodologico { get; set; }

        public virtual Paciente paciente { get; set; }

        public virtual Podologo podologo { get; set; }

        public virtual TipoEstudio tipoEstudio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PruebasComplementarias> pruebasComplementarias { get; set; }
    }
}
