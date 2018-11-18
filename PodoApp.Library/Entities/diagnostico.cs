namespace PodoApp.Library.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("diagnostico")]
    public partial class Diagnostico
    {
        [Key]
        public Guid idDiagnostico { get; set; }

        public string anotaciones { get; set; }

        public Guid? id_primera_visita { get; set; }

        public Guid? id_tratamiento { get; set; }

        public virtual PrimeraVisita primeraVisita { get; set; }

        public virtual Tratamiento tratamiento { get; set; }
    }
}
