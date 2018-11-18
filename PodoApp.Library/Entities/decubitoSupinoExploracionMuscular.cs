namespace PodoApp.Library.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("decubitoSupinoExploracionMuscular")]
    public partial class DecubitoSupinoExploracionMuscular
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DecubitoSupinoExploracionMuscular()
        {
            estudioOrtopodologico = new HashSet<EstudioOrtopodologico>();
        }

        [Key]
        [Column(Order = 0)]
        public Guid idEMuscularPieIzdo { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid idEMuscularPieDcho { get; set; }

        public string aductoresCaderaIzdo { get; set; }

        public string aductoresCaderaDcho { get; set; }

        public string cudricepsFemoralIzdo { get; set; }

        public string cudricepsFemoralDcho { get; set; }

        public string isquiotibialesIzdo { get; set; }

        public string isquiotibialesDcho { get; set; }

        public string tibialPosteriorIzdo { get; set; }

        public string tibialPosteriorDcho { get; set; }

        public string flexProp1Izdo { get; set; }

        public string flexProp1Dcho { get; set; }

        public string plcYpplIzdo { get; set; }

        public string plcYpplDcho { get; set; }

        public string tibialAnterioryExteriorIzdo { get; set; }

        public string tibialAnterioryExteriorDcho { get; set; }

        public string extComunDedosIzdo { get; set; }

        public string extComunDedosDcho { get; set; }

        public string musculosFlexoresDorsalesIzdo { get; set; }

        public string musculosFlexoresDorsalesDcho { get; set; }

        public string musculosFlexoresPlantaresIzdo { get; set; }

        public string musculosFlexoresPlantaresDcho { get; set; }

        public string musculosPronatoriosIzdo { get; set; }

        public string musculosPronatoriosDcho { get; set; }

        public string musculosSemipronatoriosIzdo { get; set; }

        public string musculosSemipronatoriosDcho { get; set; }

        public bool simetriaIzdo { get; set; }

        public bool simetriaDcho { get; set; }

        public bool asimetriaIzdo { get; set; }

        public bool asimetriaDcho { get; set; }

        public string otrosIzdo { get; set; }

        public string otrosDcho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstudioOrtopodologico> estudioOrtopodologico { get; set; }
    }
}
