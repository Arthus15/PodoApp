namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("retropie")]
    public partial class Retropie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Retropie()
        {
            bipedestacion = new HashSet<Bipedestacion>();
        }

        [Key]
        public Guid idRetropie { get; set; }

        public bool varo { get; set; }

        public bool valgo { get; set; }

        public bool neutro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Bipedestacion> bipedestacion { get; set; }
    }
}
