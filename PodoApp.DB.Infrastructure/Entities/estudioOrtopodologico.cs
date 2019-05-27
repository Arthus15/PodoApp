namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estudioOrtopodologico")]
    public partial class EstudioOrtopodologico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstudioOrtopodologico()
        {
            primeraVisita = new HashSet<PrimeraVisita>();
        }

        [Key]
        public Guid idEOrtopodologico { get; set; }

        public Guid? id_dse_articular_izdo { get; set; }

        public Guid? id_dse_articular_dcho { get; set; }

        public Guid? id_dse_muscular_dcho { get; set; }

        public Guid? id_dse_muscular_izdo { get; set; }

        public Guid? id_dse_morfologico { get; set; }

        public Guid? id_dp_articular_dcho { get; set; }

        public Guid? id_dp_articular_izdo { get; set; }

        public Guid? id_se_articular_dcho { get; set; }

        public Guid? id_se_articular_izdo { get; set; }

        public Guid? id_se_muscular_dcho { get; set; }

        public Guid? id_se_muscular_izdo { get; set; }

        public Guid? id_adv_frontal { get; set; }

        public Guid? id_adv_sagital { get; set; }

        public Guid? id_deambulacion { get; set; }

        public Guid? id_bipedestacion { get; set; }

        public Guid? id_pulsos { get; set; }

        [JsonIgnore]
        public virtual Bipedestacion bipedestacion { get; set; }

        [JsonIgnore]
        public virtual Deambulacion deambulacion { get; set; }

        [JsonIgnore]
        public virtual DecubitoPronoExploracionArticular decubitoPronoExploracionArticular { get; set; }

        [JsonIgnore]
        public virtual DecubitoSupinoExploracionArticular decubitoSupinoExploracionArticular { get; set; }

        [JsonIgnore]
        public virtual DecubitoSupinoExploracionMorfologica decubitoSupinoExploracionMorfologica { get; set; }

        [JsonIgnore]
        public virtual DecubitoSupinoExploracionMuscular decubitoSupinoExploracionMuscular { get; set; }

        [JsonIgnore]
        public virtual DecubitoSupinoPulsos decubitoSupinoPulsos { get; set; }

        [JsonIgnore]
        public virtual SedestacionExploracionArticular sedestacionExploracionArticular { get; set; }

        [JsonIgnore]
        public virtual SedestacionExploracionMuscular sedestacionExploracionMuscular { get; set; }

        [JsonIgnore]
        public virtual VisionFrontal visionFrontal { get; set; }

        [JsonIgnore]
        public virtual VisionSagital visionSagital { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<PrimeraVisita> primeraVisita { get; set; }
    }
}
