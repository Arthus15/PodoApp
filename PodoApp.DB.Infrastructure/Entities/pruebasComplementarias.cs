namespace PodoApp.DB.Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PruebasComplementarias
    {
        [Key]
        public Guid idPrueba { get; set; }

        public byte[] pedigrafia { get; set; }

        public byte[] rayosX { get; set; }

        public byte[] analisisSanguineo { get; set; }

        public byte[] cultivo { get; set; }

        public byte[] doppler { get; set; }

        public byte[] ecografia { get; set; }

        public byte[] fotos { get; set; }

        public DateTime? fecha { get; set; }

        public Guid? id_primera_visita { get; set; }

        public virtual PrimeraVisita primeraVisita { get; set; }
    }
}
