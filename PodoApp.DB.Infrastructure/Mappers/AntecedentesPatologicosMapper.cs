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
            dest.patologiaPrevia = source.patologiaPrevia;
            dest.enfermedadInfantil = source.enfermedadInfantil;
            dest.antecedentesTraumatico = source.antecedentesTraumatico;
            dest.bursitis = source.bursitis;
            dest.capsulitis = source.capsulitis;
            dest.enfermedadReumatica = source.enfermedadReumatica;
            dest.tipoEnfermedadReumatica = source.tipoEnfermedadReumatica;
            dest.ciatica = source.ciatica;
            dest.otros = source.otros;
            dest.distension = source.distension;
            dest.esguince = source.esguince;
            dest.tendinitis = source.tendinitis;
            dest.contracturas = source.contracturas;
            dest.luxacion = source.luxacion;
            dest.subluxacion = source.subluxacion;
            dest.fisura = source.fisura;
            dest.fractura = source.fractura;
        }
    }
}
