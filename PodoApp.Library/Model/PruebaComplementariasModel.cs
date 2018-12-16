using System;

namespace PodoApp.Library.Model
{
    public class PruebaComplementariasModel
    {
        public System.Guid idPrueba { get; set; }
        public byte[] pedigrafia { get; set; }
        public byte[] rayosX { get; set; }
        public byte[] analisisSanguineo { get; set; }
        public byte[] cultivo { get; set; }
        public byte[] doppler { get; set; }
        public byte[] ecografia { get; set; }
        public byte[] fotos { get; set; }
        public DateTime? fecha { get; set; }
        public Guid? id_primera_visita { get; set; }
    }
}