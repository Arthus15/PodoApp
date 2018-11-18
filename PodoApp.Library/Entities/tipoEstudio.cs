namespace PodoApp.Library.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tipoEstudio")]
    public partial class TipoEstudio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoEstudio()
        {
            primeraVisita = new HashSet<PrimeraVisita>();
        }

        [Key]
        public Guid idTipoEstudio { get; set; }

        public bool ortopodologico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrimeraVisita> primeraVisita { get; set; }
    }
}
