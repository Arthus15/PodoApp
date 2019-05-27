namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("visionFrontal")]
    public partial class VisionFrontal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VisionFrontal()
        {
            estudioOrtopodologico = new HashSet<EstudioOrtopodologico>();
        }

        [Key]
        public Guid idFrontal { get; set; }

        public string anterior { get; set; }

        public string posterior { get; set; }

        public Guid? id_anguloFick { get; set; }

        public virtual AnguloFick anguloFick { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<EstudioOrtopodologico> estudioOrtopodologico { get; set; }
    }
}
