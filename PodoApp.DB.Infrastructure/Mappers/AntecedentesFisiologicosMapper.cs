using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class AntecedentesFisiologicosMapper
    {
        public static AntecedentesFisiologicosModel EntityToModel(this AntecedentesFisiologicos antecedentes)
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

        public static AntecedentesFisiologicos ModelToEntity(this AntecedentesFisiologicosModel antecedentes)
        {
            return new AntecedentesFisiologicos
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

        public static void MapChanges(this AntecedentesFisiologicos source, ref AntecedentesFisiologicos dest)
        {
            dest.andador = source.andador;
            dest.tacata = source.tacata;
            dest.inicioDeambulacion = source?.inicioDeambulacion;
            dest.habitosPosturales = source.habitosPosturales;
            dest.cambiosPonderales = source?.cambiosPonderales;
            dest.zurdo = source.zurdo;
            dest.diestro = source.diestro;
            dest.ambidiestro = source.ambidiestro;
            dest.otros = source.otros;
            dest.partoCabeza = source.partoCabeza;
            dest.partoNalgas = source.partoNalgas;
        }
    }
}
