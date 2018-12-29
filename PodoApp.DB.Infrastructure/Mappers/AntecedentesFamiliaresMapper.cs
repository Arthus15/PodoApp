using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class AntecedentesFamiliaresMapper
    {
        public static AntecedentesFamiliaresModel EntityToModel(this AntecedentesFamiliares antecedentes)
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

        public static AntecedentesFamiliares ModelToEntity(this AntecedentesFamiliaresModel antecedentes)
        {
            return new AntecedentesFamiliares
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

        public static void MapChanges(this AntecedentesFamiliares source, ref AntecedentesFamiliares dest)
        {
            source.dismetrias = dest.dismetrias;
            source.escoliosis = dest.escoliosis;
            source.tibiasVaras = dest.tibiasVaras;
            source.piesPlanos = dest.piesPlanos;
            source.piesCavos = dest.piesCavos;
            source.piesValgos = dest.piesValgos;
            source.piesZambos = dest.piesZambos;
            source.hallusValgus = dest.hallusValgus;
            source.dedosGarra = dest.dedosGarra;
            source.otros = dest.otros;
            source.genuVaro = dest.genuVaro;
            source.genuValgo = dest.genuValgo;
            source.metaAductus = dest.metaAductus;
            source.metaVarus = dest.metaVarus;
        }
    }
}
