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
            dest.dismetrias = source.dismetrias;
            dest.escoliosis = source.escoliosis;
            dest.tibiasVaras = source.tibiasVaras;
            dest.piesPlanos = source.piesPlanos;
            dest.piesCavos = source.piesCavos;
            dest.piesValgos = source.piesValgos;
            dest.piesZambos = source.piesZambos;
            dest.hallusValgus = source.hallusValgus;
            dest.dedosGarra = source.dedosGarra;
            dest.otros = source.otros;
            dest.genuVaro = source.genuVaro;
            dest.genuValgo = source.genuValgo;
            dest.metaAductus = source.metaAductus;
            dest.metaVarus = source.metaVarus;
        }
    }
}
