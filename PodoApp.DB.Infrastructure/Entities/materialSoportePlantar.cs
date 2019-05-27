namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("materialSoportePlantar")]
    public partial class MaterialSoportePlantar
    {
        [Key]
        public Guid idMaterialSoportePlantar { get; set; }

        public bool TAD { get; set; }

        public bool resinas { get; set; }

        public bool EVA { get; set; }

        public bool propileno { get; set; }

        public string componentes { get; set; }

        public string otros { get; set; }

        public Guid? id_tratamiento { get; set; }

        [JsonIgnore]

        public virtual Tratamiento tratamiento { get; set; }
    }
}
