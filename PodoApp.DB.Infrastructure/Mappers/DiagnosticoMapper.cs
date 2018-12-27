using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class DiagnosticoMapper
    {
        public static DiagnosticoModel EntityToModel(this Diagnostico diagnostico)
        {
            return new DiagnosticoModel
            {
                idDiagnostico = diagnostico.idDiagnostico,
                id_primera_visita = diagnostico.id_primera_visita,
                id_tratamiento = diagnostico.id_tratamiento,
                anotaciones = diagnostico.anotaciones
            };
        }

        public static Diagnostico ModelToEntity(this DiagnosticoModel diagnostico)
        {
            return new Diagnostico
            {
                idDiagnostico = diagnostico.idDiagnostico,
                id_primera_visita = diagnostico.id_primera_visita,
                id_tratamiento = diagnostico.id_tratamiento,
                anotaciones = diagnostico.anotaciones
            };
        }
    }
}
