namespace PodoApp.Library.Entities
{
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

        public virtual Bipedestacion bipedestacion { get; set; }

        public virtual Deambulacion deambulacion { get; set; }

        public virtual DecubitoPronoExploracionArticular decubitoPronoExploracionArticular { get; set; }

        public virtual DecubitoSupinoExploracionArticular decubitoSupinoExploracionArticular { get; set; }

        public virtual DecubitoSupinoExploracionMorfologica decubitoSupinoExploracionMorfologica { get; set; }

        public virtual DecubitoSupinoExploracionMuscular decubitoSupinoExploracionMuscular { get; set; }

        public virtual DecubitoSupinoPulsos decubitoSupinoPulsos { get; set; }

        public virtual SedestacionExploracionArticular sedestacionExploracionArticular { get; set; }

        public virtual SedestacionExploracionMuscular sedestacionExploracionMuscular { get; set; }

        public virtual VisionFrontal visionFrontal { get; set; }

        public virtual VisionSagital visionSagital { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrimeraVisita> primeraVisita { get; set; }
    }
}
