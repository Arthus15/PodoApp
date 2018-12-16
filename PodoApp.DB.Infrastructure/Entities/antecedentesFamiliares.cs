namespace PodoApp.DB.Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("antecedentesFamiliares")]
    public partial class AntecedentesFamiliares
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AntecedentesFamiliares()
        {
            historialClinico = new HashSet<HistorialClinico>();
        }

        [Key]
        public Guid idAFamiliares { get; set; }

        public bool dismetrias { get; set; }

        public bool escoliosis { get; set; }

        public bool tibiasVaras { get; set; }

        public bool piesPlanos { get; set; }

        public bool piesCavos { get; set; }

        public bool piesValgos { get; set; }

        public bool piesZambos { get; set; }

        public bool hallusValgus { get; set; }

        public bool dedosGarra { get; set; }

        public string otros { get; set; }

        public bool genuVaro { get; set; }

        public bool genuValgo { get; set; }

        public bool metaAductus { get; set; }

        public bool metaVarus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialClinico> historialClinico { get; set; }
    }
}
