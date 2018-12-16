namespace PodoApp.DB.Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("calzadoHabitual")]
    public partial class CalzadoHabitual
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CalzadoHabitual()
        {
            primeraVisita = new HashSet<PrimeraVisita>();
        }

        [Key]
        public Guid idCalzado { get; set; }

        public bool deportivos { get; set; }

        public bool vestir { get; set; }

        public bool sandalias { get; set; }

        public bool botines { get; set; }

        public bool tacones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrimeraVisita> primeraVisita { get; set; }
    }
}
