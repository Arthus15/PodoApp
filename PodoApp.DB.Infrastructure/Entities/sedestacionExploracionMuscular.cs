namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sedestacionExploracionMuscular")]
    public partial class SedestacionExploracionMuscular
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SedestacionExploracionMuscular()
        {
            estudioOrtopodologico = new HashSet<EstudioOrtopodologico>();
        }

        [Key]
        [Column(Order = 0)]
        public Guid idEMuscularPieIzdo { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid idEMuscularPieDcho { get; set; }

        public bool hiperlaxitudArticularIzdo { get; set; }

        public bool hiperlaxitudArticularDcho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<EstudioOrtopodologico> estudioOrtopodologico { get; set; }
    }
}
