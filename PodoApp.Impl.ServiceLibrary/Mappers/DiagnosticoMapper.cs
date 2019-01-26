using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class DiagnosticoMapper
    {
        public static DiagnosticoDto ModelToDto(this DiagnosticoModel diagnostico)
        {
            return new DiagnosticoDto
            {
                idDiagnostico = diagnostico.idDiagnostico,
                id_primera_visita = diagnostico.id_primera_visita,
                id_tratamiento = diagnostico.id_tratamiento,
                anotaciones = diagnostico.anotaciones,
                Tratamiento = diagnostico.tratamiento?.ModelToDto()
            };
        }

        public static DiagnosticoModel DtoToModel(this DiagnosticoDto diagnostico)
        {
            return new DiagnosticoModel
            {
                idDiagnostico = diagnostico.idDiagnostico,
                id_primera_visita = diagnostico.id_primera_visita,
                id_tratamiento = diagnostico.id_tratamiento,
                anotaciones = diagnostico.anotaciones
            };
        }
    }
}
