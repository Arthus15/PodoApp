namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("antecedentesPatologicos")]
    public partial class AntecedentesPatologicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AntecedentesPatologicos()
        {
            historialClinico = new HashSet<HistorialClinico>();
        }

        [Key]
        public Guid idAPatologico { get; set; }

        public string patologiaPrevia { get; set; }

        public string enfermedadInfantil { get; set; }

        public string antecedentesTraumatico { get; set; }

        public bool bursitis { get; set; }

        public bool capsulitis { get; set; }

        public bool enfermedadReumatica { get; set; }

        public string tipoEnfermedadReumatica { get; set; }

        public bool ciatica { get; set; }

        public string otros { get; set; }

        public bool distension { get; set; }

        public bool esguince { get; set; }

        public bool tendinitis { get; set; }

        public bool contracturas { get; set; }

        public bool luxacion { get; set; }

        public bool subluxacion { get; set; }

        public bool fisura { get; set; }

        public bool fractura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<HistorialClinico> historialClinico { get; set; }
    }
}
