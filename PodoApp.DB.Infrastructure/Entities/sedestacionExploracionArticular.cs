namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sedestacionExploracionArticular")]
    public partial class SedestacionExploracionArticular
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SedestacionExploracionArticular()
        {
            estudioOrtopodologico = new HashSet<EstudioOrtopodologico>();
        }

        [Key]
        [Column(Order = 0)]
        public Guid idEArticularPieIzdo { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid idEArticularPieDcho { get; set; }

        public double? anteversionFemoralNinosIzda { get; set; }

        public double? anteversionFemoralNinosDcha { get; set; }

        public double? anteversionFemoralAdultosIzda { get; set; }

        public double? anteversionFemoralAdultosDcha { get; set; }

        public double? anguloTorsionBimaleolarIzda { get; set; }

        public double? anguloTorsionBimaleolarDcha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<EstudioOrtopodologico> estudioOrtopodologico { get; set; }
    }
}
