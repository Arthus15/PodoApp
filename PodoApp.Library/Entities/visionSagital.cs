namespace PodoApp.Library.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("visionSagital")]
    public partial class VisionSagital
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VisionSagital()
        {
            estudioOrtopodologico = new HashSet<EstudioOrtopodologico>();
        }

        [Key]
        public Guid idSagital { get; set; }

        public string estatica { get; set; }

        public string dinamica { get; set; }

        public string otros { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstudioOrtopodologico> estudioOrtopodologico { get; set; }
    }
}
