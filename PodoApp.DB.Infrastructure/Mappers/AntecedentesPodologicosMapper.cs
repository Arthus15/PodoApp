using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class AntecedentesPodologicosMapper
    {
        public static AntecedentesPodologicosModel EntityToModel(this AntecedentesPodologicos antecedentes)
        {
            return new AntecedentesPodologicosModel
            {
                idAPodologicos = antecedentes.idAPodologicos,
                haidoPodologo = antecedentes.haidoPodologo,
                antecedentes = antecedentes.antecedentes
            };
        }

        public static AntecedentesPodologicos ModelToEntity(this AntecedentesPodologicosModel antecedentes)
        {
            return new AntecedentesPodologicos
            {
                idAPodologicos = antecedentes.idAPodologicos,
                haidoPodologo = antecedentes.haidoPodologo,
                antecedentes = antecedentes.antecedentes
            };
        }

        public static void MapChanges(this AntecedentesPodologicos source, ref AntecedentesPodologicos dest)
        {
            source.haidoPodologo = dest.haidoPodologo;
            source.antecedentes = dest.antecedentes;
        }


    }
}
