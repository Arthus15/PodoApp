namespace PodoApp.Library.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("decubitoPronoExploracionArticular")]
    public partial class DecubitoPronoExploracionArticular
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DecubitoPronoExploracionArticular()
        {
            estudioOrtopodologico = new HashSet<EstudioOrtopodologico>();
        }

        [Key]
        [Column(Order = 0)]
        public Guid idEArticularPieIzdo { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid idEArticularPieDcho { get; set; }

        public double? caderaRotInternaIzdo { get; set; }

        public double? caderaRotInternaDcho { get; set; }

        public double? caderaRotExternaIzdo { get; set; }

        public double? caderaRotExternaDcho { get; set; }

        public double? torsionFemoralInternaIzdo { get; set; }

        public double? torsionFemoralInternaDcho { get; set; }

        public double? torsionFemoralExternaIzdo { get; set; }

        public double? torsionFemoralExternaDcho { get; set; }

        public double? torsionTibialInternaIzdo { get; set; }

        public double? torsionTibialInternaDcho { get; set; }

        public double? torsionTibialExternaIzdo { get; set; }

        public double? torsionTibialExternaDcho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstudioOrtopodologico> estudioOrtopodologico { get; set; }
    }
}
