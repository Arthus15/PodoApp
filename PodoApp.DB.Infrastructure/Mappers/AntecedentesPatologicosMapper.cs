using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class AntecedentesPatologicosMapper
    {
        public static AntecedentesPatologicosModel EntityToModel(this AntecedentesPatologicos antecedentes)
        {
            return new AntecedentesPatologicosModel
            {
                idAPatologico = antecedentes.idAPatologico,
                patologiaPrevia = antecedentes.patologiaPrevia,
                enfermedadInfantil = antecedentes.enfermedadInfantil,
                antecedentesTraumatico = antecedentes.antecedentesTraumatico,
                bursitis = antecedentes.bursitis,
                capsulitis = antecedentes.capsulitis,
                enfermedadReumatica = antecedentes.enfermedadReumatica,
                tipoEnfermedadReumatica = antecedentes.tipoEnfermedadReumatica,
                ciatica = antecedentes.ciatica,
                otros = antecedentes.otros,
                distension = antecedentes.distension,
                esguince = antecedentes.esguince,
                tendinitis = antecedentes.tendinitis,
                contracturas = antecedentes.contracturas,
                luxacion = antecedentes.luxacion,
                subluxacion = antecedentes.subluxacion,
                fisura = antecedentes.fisura,
                fractura = antecedentes.fractura
            };
        }

        public static AntecedentesPatologicos ModelToEntity(this AntecedentesPatologicosModel antecedentes)
        {
            return new AntecedentesPatologicos
            {
                idAPatologico = antecedentes.idAPatologico,
                patologiaPrevia = antecedentes.patologiaPrevia,
                enfermedadInfantil = antecedentes.enfermedadInfantil,
                antecedentesTraumatico = antecedentes.antecedentesTraumatico,
                bursitis = antecedentes.bursitis,
                capsulitis = antecedentes.capsulitis,
                enfermedadReumatica = antecedentes.enfermedadReumatica,
                tipoEnfermedadReumatica = antecedentes.tipoEnfermedadReumatica,
                ciatica = antecedentes.ciatica,
                otros = antecedentes.otros,
                distension = antecedentes.distension,
                esguince = antecedentes.esguince,
                tendinitis = antecedentes.tendinitis,
                contracturas = antecedentes.contracturas,
                luxacion = antecedentes.luxacion,
                subluxacion = antecedentes.subluxacion,
                fisura = antecedentes.fisura,
                fractura = antecedentes.fractura
            };
        }

        public static void MapChanges(this AntecedentesPatologicos source, ref AntecedentesPatologicos dest)
        {
            source.patologiaPrevia = dest.patologiaPrevia;
            source.enfermedadInfantil = dest.enfermedadInfantil;
            source.antecedentesTraumatico = dest.antecedentesTraumatico;
            source.bursitis = dest.bursitis;
            source.capsulitis = dest.capsulitis;
            source.enfermedadReumatica = dest.enfermedadReumatica;
            source.tipoEnfermedadReumatica = dest.tipoEnfermedadReumatica;
            source.ciatica = dest.ciatica;
            source.otros = dest.otros;
            source.distension = dest.distension;
            source.esguince = dest.esguince;
            source.tendinitis = dest.tendinitis;
            source.contracturas = dest.contracturas;
            source.luxacion = dest.luxacion;
            source.subluxacion = dest.subluxacion;
            source.fisura = dest.fisura;
            source.fractura = dest.fractura;
        }
    }
}
