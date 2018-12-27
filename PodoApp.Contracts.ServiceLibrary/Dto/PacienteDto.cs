using System;
using System.Collections.Generic;

namespace PodoApp.Contracts.ServiceLibrary.Dto
{
    public class PacienteDto
    {
        public Guid idPaciente { get; set; }

        public string medicacionHabitual { get; set; }

        public string observacion { get; set; }

        public Guid? id_podologo { get; set; }

        public Guid? id_historial_clinico { get; set; }

        public Guid? id_persona { get; set; }

        public ICollection<ConsultaDto> consulta { get; set; }

        public ICollection<PrimeraVisitaDto> primeraVisita { get; set; }

        public HistorialClinicoDto historialClinico { get; set; }

        public PersonaDto persona { get; set; }

        public PodologoDto podologo { get; set; }
    }
}
