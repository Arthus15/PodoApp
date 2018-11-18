namespace PodoApp.Library.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("podologo")]
    public partial class Podologo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Podologo()
        {
            consulta = new HashSet<Consulta>();
            paciente = new HashSet<Paciente>();
            primeraVisita = new HashSet<PrimeraVisita>();
        }

        [Key]
        public Guid idPodologo { get; set; }

        [StringLength(50)]
        public string idTitulo { get; set; }

        public string email { get; set; }

        public Guid? id_persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consulta> consulta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paciente> paciente { get; set; }

        public virtual Persona persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrimeraVisita> primeraVisita { get; set; }
    }
}
