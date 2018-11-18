namespace PodoApp.Library.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("consulta")]
    public partial class Consulta
    {
        [Key]
        public Guid idConsulta { get; set; }

        public DateTime? fecha { get; set; }

        public string descripcion { get; set; }

        public Guid? id_paciente { get; set; }

        public Guid? id_podologo { get; set; }

        public virtual Paciente paciente { get; set; }

        public virtual Podologo podologo { get; set; }
    }
}
