namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("historialClinico")]
    public partial class HistorialClinico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HistorialClinico()
        {
            paciente = new HashSet<Paciente>();
        }

        [Key]
        public Guid idHistorialClinico { get; set; }

        [StringLength(10)]
        public string numeroHistorialClinico { get; set; }

        public Guid? id_ant_podologicos { get; set; }

        public Guid? id_ant_patologicos { get; set; }

        public Guid? id_ant_fisiologicos { get; set; }

        public Guid? id_ant_familiares { get; set; }

        public Guid? id_estudio { get; set; }

        [JsonIgnore]
        public virtual AntecedentesFamiliares antecedentesFamiliares { get; set; }

        [JsonIgnore]
        public virtual AntecedentesFisiologicos antecedentesFisiologicos { get; set; }

        [JsonIgnore]
        public virtual AntecedentesPatologicos antecedentesPatologicos { get; set; }

        [JsonIgnore]
        public virtual AntecedentesPodologicos antecedentesPodologicos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Paciente> paciente { get; set; }
    }
}
