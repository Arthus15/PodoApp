namespace PodoApp.Library.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("paciente")]
    public partial class Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paciente()
        {
            consulta = new HashSet<Consulta>();
            primeraVisita = new HashSet<PrimeraVisita>();
        }

        [Key]
        public Guid idPaciente { get; set; }

        public string medicacionHabitual { get; set; }

        public string observacion { get; set; }

        public Guid? id_podologo { get; set; }

        public Guid? id_historial_clinico { get; set; }

        public Guid? id_persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consulta> consulta { get; set; }

        public virtual HistorialClinico historialClinico { get; set; }

        public virtual Persona persona { get; set; }

        public virtual Podologo podologo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrimeraVisita> primeraVisita { get; set; }
    }
}
