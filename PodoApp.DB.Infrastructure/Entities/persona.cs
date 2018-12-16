namespace PodoApp.DB.Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("persona")]
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            paciente = new HashSet<Paciente>();
            podologo = new HashSet<Podologo>();
        }

        [Key]
        public Guid idPersona { get; set; }

        public string nombre { get; set; }

        public string apellido1 { get; set; }

        public string apellido2 { get; set; }

        public DateTime? fechaNacimiento { get; set; }

        public int? edad { get; set; }

        public string profesion { get; set; }

        public string calle { get; set; }

        public string ciudad { get; set; }

        public string provincia { get; set; }

        public string pais { get; set; }

        [StringLength(20)]
        public string telefono { get; set; }

        [StringLength(10)]
        public string dni { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paciente> paciente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Podologo> podologo { get; set; }
    }
}
