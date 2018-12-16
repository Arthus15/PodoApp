namespace PodoApp.DB.Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("formulaMetatarsal")]
    public partial class FormulaMetatarsal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormulaMetatarsal()
        {
            decubitoSupinoExploracionMorfologica = new HashSet<DecubitoSupinoExploracionMorfologica>();
        }

        [Key]
        public Guid idFormulaMetatarsal { get; set; }

        public bool indexMinus { get; set; }

        public bool indexPlus { get; set; }

        public bool indexPlusMinus { get; set; }

        public string otra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DecubitoSupinoExploracionMorfologica> decubitoSupinoExploracionMorfologica { get; set; }
    }
}
