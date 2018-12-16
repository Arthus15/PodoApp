namespace PodoApp.DB.Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("formulaDigital")]
    public partial class FormulaDigital
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormulaDigital()
        {
            decubitoSupinoExploracionMorfologica = new HashSet<DecubitoSupinoExploracionMorfologica>();
        }

        [Key]
        public Guid idFormulaDigital { get; set; }

        public bool egipcia { get; set; }

        public bool griega { get; set; }

        public bool cuadrada { get; set; }

        public string otra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DecubitoSupinoExploracionMorfologica> decubitoSupinoExploracionMorfologica { get; set; }
    }
}
