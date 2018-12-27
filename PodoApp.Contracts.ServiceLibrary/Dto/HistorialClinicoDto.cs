using System;
using System.Collections.Generic;

namespace PodoApp.Contracts.ServiceLibrary.Dto
{
    public class HistorialClinicoDto
    {
        public System.Guid idHistorialClinico { get; set; }
        public string numeroHistorialClinico { get; set; }
        public Guid? id_ant_podologicos { get; set; }
        public Guid? id_ant_patologicos { get; set; }
        public Guid? id_ant_fisiologicos { get; set; }
        public Guid? id_ant_familiares { get; set; }
        public Guid? id_estudio { get; set; }
        public virtual ICollection<PacienteDto> paciente { get; set; }
    }
}