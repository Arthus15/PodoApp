using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class MaterialSoportePlantarMapper
    {

        public static MaterialSoportePlantarDto ModelToDto(this MaterialSoportePlantarModel materialSoportePlantar)
        {
            return new MaterialSoportePlantarDto
            {
                idMaterialSoportePlantar = materialSoportePlantar.idMaterialSoportePlantar,
                id_tratamiento = materialSoportePlantar.id_tratamiento,
                TAD = materialSoportePlantar.TAD,
                EVA = materialSoportePlantar.EVA,
                componentes = materialSoportePlantar.componentes,
                otros = materialSoportePlantar.otros,
                propileno = materialSoportePlantar.propileno,
                resinas = materialSoportePlantar.resinas,
                tratamiento = materialSoportePlantar.tratamiento?.ModelToDto()
            };
        }

        public static MaterialSoportePlantarModel DtoToModel(this MaterialSoportePlantarDto materialSoportePlantar)
        {
            return new MaterialSoportePlantarModel
            {
                idMaterialSoportePlantar = materialSoportePlantar.idMaterialSoportePlantar,
                id_tratamiento = materialSoportePlantar.id_tratamiento,
                TAD = materialSoportePlantar.TAD,
                EVA = materialSoportePlantar.EVA,
                componentes = materialSoportePlantar.componentes,
                otros = materialSoportePlantar.otros,
                propileno = materialSoportePlantar.propileno,
                resinas = materialSoportePlantar.resinas,
                tratamiento = materialSoportePlantar.tratamiento?.DtoToModel()
            };
        }
    }
}
