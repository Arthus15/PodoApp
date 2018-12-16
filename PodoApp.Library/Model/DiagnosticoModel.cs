using System;

namespace PodoApp.Library.Model
{
    public class DiagnosticoModel
    {
        public Guid idDiagnostico { get; set; }
        public string anotaciones { get; set; }
        public Guid? id_primera_visita { get; set; }
        public Guid? id_tratamiento { get; set; }
    }
}