namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("decubitoSupinoExploracionMorfologica")]
    public partial class DecubitoSupinoExploracionMorfologica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DecubitoSupinoExploracionMorfologica()
        {
            estudioOrtopodologico = new HashSet<EstudioOrtopodologico>();
        }

        [Key]
        public Guid idEMorfologica { get; set; }

        public bool antepieTriangular { get; set; }

        public string otros { get; set; }

        public Guid? id_formula_metatarsal { get; set; }

        public Guid? id_formula_digital { get; set; }

        public Guid? id_formula_podal { get; set; }

        public virtual FormulaDigital formulaDigital { get; set; }

        public virtual FormulaMetatarsal formulaMetatarsal { get; set; }

        public virtual FormulaPodal formulaPodal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<EstudioOrtopodologico> estudioOrtopodologico { get; set; }
    }
}
