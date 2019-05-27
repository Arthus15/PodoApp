namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tratamiento")]
    public partial class Tratamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tratamiento()
        {
            diagnostico = new HashSet<Diagnostico>();
            materialSoportePlantar = new HashSet<MaterialSoportePlantar>();
        }

        [Key]
        public Guid idTratamiento { get; set; }

        public bool fisico { get; set; }

        public string ejerciciosPropioceptivos { get; set; }

        public bool farmacologico { get; set; }

        public bool quiropodologico { get; set; }

        public bool ortosisDigital { get; set; }

        public string ortosisDigitalTipo { get; set; }

        public bool soportePlantar { get; set; }

        public bool vendajeFuncional { get; set; }

        public bool preventivo { get; set; }

        public string preventivoObservacion { get; set; }

        public bool calzadoterapia { get; set; }

        public string otros { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Diagnostico> diagnostico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<MaterialSoportePlantar> materialSoportePlantar { get; set; }
    }
}
