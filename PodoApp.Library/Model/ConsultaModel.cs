using System;

namespace PodoApp.Library.Model
{
    public class ConsultaModel
    {
        public Guid? idConsulta { get; set; }
        public DateTime? fecha { get; set; }
        public string descripcion { get; set; }
        public Guid? id_paciente { get; set; }
        public Guid? id_podologo { get; set; }

    }
}