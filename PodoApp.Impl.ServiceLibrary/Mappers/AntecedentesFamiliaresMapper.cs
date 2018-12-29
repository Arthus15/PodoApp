using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class AntecedentesFamiliaresMapper
    {
        public static AntecedentesFamiliaresModel DtoToModel(this AntecedentesFamiliaresDto antecedentes)
        {
            return new AntecedentesFamiliaresModel
            {
                idAFamiliares = antecedentes.idAFamiliares,
                dismetrias = antecedentes.dismetrias,
                escoliosis = antecedentes.escoliosis,
                tibiasVaras = antecedentes.tibiasVaras,
                piesPlanos = antecedentes.piesPlanos,
                piesCavos = antecedentes.piesCavos,
                piesValgos = antecedentes.piesValgos,
                piesZambos = antecedentes.piesZambos,
                hallusValgus = antecedentes.hallusValgus,
                dedosGarra = antecedentes.dedosGarra,
                otros = antecedentes.otros,
                genuVaro = antecedentes.genuVaro,
                genuValgo = antecedentes.genuValgo,
                metaAductus = antecedentes.metaAductus,
                metaVarus = antecedentes.metaVarus
            };
        }

        public static AntecedentesFamiliaresDto ModelToDto(this AntecedentesFamiliaresModel antecedentes)
        {
            return new AntecedentesFamiliaresDto
            {
                idAFamiliares = antecedentes.idAFamiliares,
                dismetrias = antecedentes.dismetrias,
                escoliosis = antecedentes.escoliosis,
                tibiasVaras = antecedentes.tibiasVaras,
                piesPlanos = antecedentes.piesPlanos,
                piesCavos = antecedentes.piesCavos,
                piesValgos = antecedentes.piesValgos,
                piesZambos = antecedentes.piesZambos,
                hallusValgus = antecedentes.hallusValgus,
                dedosGarra = antecedentes.dedosGarra,
                otros = antecedentes.otros,
                genuVaro = antecedentes.genuVaro,
                genuValgo = antecedentes.genuValgo,
                metaAductus = antecedentes.metaAductus,
                metaVarus = antecedentes.metaVarus
            };
        }
    }
}
