using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class AntecedentesFisiologicosMapper
    {
        public static AntecedentesFisiologicosModel DtoToModel(this AntecedentesFisiologicosDto antecedentes)
        {
            return new AntecedentesFisiologicosModel
            {
                idAFisiologico = antecedentes.idAFisiologico,
                andador = antecedentes.andador,
                tacata = antecedentes.tacata,
                inicioDeambulacion = antecedentes?.inicioDeambulacion,
                habitosPosturales = antecedentes.habitosPosturales,
                cambiosPonderales = antecedentes?.cambiosPonderales,
                zurdo = antecedentes.zurdo,
                diestro = antecedentes.diestro,
                ambidiestro = antecedentes.ambidiestro,
                otros = antecedentes.otros,
                partoCabeza = antecedentes.partoCabeza,
                partoNalgas = antecedentes.partoNalgas
            };
        }

        public static AntecedentesFisiologicosDto ModelToDto(this AntecedentesFisiologicosModel antecedentes)
        {
            return new AntecedentesFisiologicosDto
            {
                idAFisiologico = antecedentes.idAFisiologico,
                andador = antecedentes.andador,
                tacata = antecedentes.tacata,
                inicioDeambulacion = antecedentes?.inicioDeambulacion,
                habitosPosturales = antecedentes.habitosPosturales,
                cambiosPonderales = antecedentes?.cambiosPonderales,
                zurdo = antecedentes.zurdo,
                diestro = antecedentes.diestro,
                ambidiestro = antecedentes.ambidiestro,
                otros = antecedentes.otros,
                partoCabeza = antecedentes.partoCabeza,
                partoNalgas = antecedentes.partoNalgas
            };
        }
    }
}
