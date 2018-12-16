namespace PodoApp.DB.Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("antecedentesFisiologicos")]
    public partial class AntecedentesFisiologicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AntecedentesFisiologicos()
        {
            historialClinico = new HashSet<HistorialClinico>();
        }

        [Key]
        public Guid idAFisiologico { get; set; }

        public bool andador { get; set; }

        public bool tacata { get; set; }

        public int? inicioDeambulacion { get; set; }

        public string habitosPosturales { get; set; }

        public int? cambiosPonderales { get; set; }

        public bool zurdo { get; set; }

        public bool diestro { get; set; }

        public bool ambidiestro { get; set; }

        public string otros { get; set; }

        public bool partoCabeza { get; set; }

        public bool partoNalgas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialClinico> historialClinico { get; set; }
    }
}
