using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class ConsultaMapper
    {
        public static ConsultaModel DtoToModel (this ConsultaDto consulta)
        {
            return new ConsultaModel
            {
                idConsulta = consulta.idConsulta,
                id_paciente = consulta.id_paciente,
                id_podologo = consulta.id_podologo,
                descripcion = consulta.descripcion,
                fecha = consulta.fecha
            };
        }

        public static ConsultaDto ModelToDto(this ConsultaModel consulta)
        {
            return new ConsultaDto
            {
                idConsulta = (Guid)consulta.idConsulta,
                id_paciente = consulta.id_paciente,
                id_podologo = consulta.id_podologo,
                descripcion = consulta.descripcion,
                fecha = consulta.fecha
            };
        }
    }
}
