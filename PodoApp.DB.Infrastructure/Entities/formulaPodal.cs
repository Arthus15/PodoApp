namespace PodoApp.DB.Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("formulaPodal")]
    public partial class FormulaPodal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormulaPodal()
        {
            decubitoSupinoExploracionMorfologica = new HashSet<DecubitoSupinoExploracionMorfologica>();
        }

        [Key]
        public Guid idFormulaPodal { get; set; }

        public bool normolineo { get; set; }

        public bool longilineo { get; set; }

        public bool brevilineo { get; set; }

        public string otra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DecubitoSupinoExploracionMorfologica> decubitoSupinoExploracionMorfologica { get; set; }
    }
}
