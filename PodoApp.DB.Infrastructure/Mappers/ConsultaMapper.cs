using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class ConsultaMapper
    {
        public static ConsultaModel EntitytToModel(this Consulta consulta)
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

        public static Consulta ModelToEntity(this ConsultaModel consulta)
        {
            return new Consulta
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
