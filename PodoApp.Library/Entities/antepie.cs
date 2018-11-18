namespace PodoApp.Library.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("antepie")]
    public partial class Antepie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Antepie()
        {
            bipedestacion = new HashSet<Bipedestacion>();
        }

        [Key]
        public Guid idAntepie { get; set; }

        public bool varo { get; set; }

        public bool supinado { get; set; }

        public bool valgo { get; set; }

        public bool neutro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bipedestacion> bipedestacion { get; set; }
    }
}
