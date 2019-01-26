using System;

namespace PodoApp.Contracts.ServiceLibrary.Dto
{
    public class DiagnosticoDto
    {
        public Guid idDiagnostico { get; set; }
        public string anotaciones { get; set; }
        public Guid? id_primera_visita { get; set; }
        public Guid? id_tratamiento { get; set; }
        public TratamientoDto Tratamiento { get; set; }
    }
}