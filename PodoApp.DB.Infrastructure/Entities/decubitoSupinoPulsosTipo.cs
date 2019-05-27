namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("decubitoSupinoPulsosTipo")]
    public partial class DecubitoSupinoPulsosTipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DecubitoSupinoPulsosTipo()
        {
            decubitoSupinoPulsos = new HashSet<DecubitoSupinoPulsos>();
        }

        [Key]
        public Guid idPulsosTipo { get; set; }

        public bool presente { get; set; }

        public bool ausente { get; set; }

        [StringLength(10)]
        public string debil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<DecubitoSupinoPulsos> decubitoSupinoPulsos { get; set; }
    }
}
