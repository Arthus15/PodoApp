namespace PodoApp.DB.Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("antecedentesPodologicos")]
    public partial class AntecedentesPodologicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AntecedentesPodologicos()
        {
            historialClinico = new HashSet<HistorialClinico>();
        }

        [Key]
        public Guid idAPodologicos { get; set; }

        public bool haidoPodologo { get; set; }

        [StringLength(50)]
        public string antecedentes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialClinico> historialClinico { get; set; }
    }
}
