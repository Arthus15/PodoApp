using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class AntecedentesPodologicosMapper
    {
        public static AntecedentesPodologicosModel DtoToModel(this AntecedentesPodologicosDto antecedentes)
        {
            return new AntecedentesPodologicosModel
            {
                idAPodologicos = antecedentes.idAPodologicos,
                haidoPodologo = antecedentes.haidoPodologo,
                antecedentes = antecedentes.antecedentes
            };
        }

        public static AntecedentesPodologicosDto ModelToDto(this AntecedentesPodologicosModel antecedentes)
        {
            return new AntecedentesPodologicosDto
            {
                idAPodologicos = antecedentes.idAPodologicos,
                haidoPodologo = antecedentes.haidoPodologo,
                antecedentes = antecedentes.antecedentes
            };
        }
    }
}
