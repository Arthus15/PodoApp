namespace PodoApp.DB.Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("anguloFick")]
    public partial class AnguloFick
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnguloFick()
        {
            visionFrontal = new HashSet<VisionFrontal>();
        }

        [Key]
        public Guid idAngulo { get; set; }

        public bool? abierto { get; set; }

        public bool? cerrado { get; set; }

        public bool? neutro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisionFrontal> visionFrontal { get; set; }
    }
}
