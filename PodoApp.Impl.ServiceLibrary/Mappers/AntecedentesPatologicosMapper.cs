using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class AntecedentesPatologicosMapper
    {
        public static AntecedentesPatologicosModel DtoToModel(this AntecedentesPatologicosDto antecedentes)
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

        public static AntecedentesPatologicosDto ModelToDto(this AntecedentesPatologicosModel antecedentes)
        {
            return new AntecedentesPatologicosDto
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
    }
}
