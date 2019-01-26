using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class MaterialSoportePlantarMapper
    {
        public static MaterialSoportePlantarModel EntityToModel(this MaterialSoportePlantar materialSoportePlantar)
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
                tratamiento = materialSoportePlantar.tratamiento?.EntityToModel()                
            };
        }

        public static MaterialSoportePlantar ModelToEntity(this MaterialSoportePlantarModel materialSoportePlantar, bool mapTratamiento = false)
        {
            return new MaterialSoportePlantar
            {
                idMaterialSoportePlantar = materialSoportePlantar.idMaterialSoportePlantar,
                id_tratamiento = materialSoportePlantar.id_tratamiento,
                TAD = materialSoportePlantar.TAD,
                EVA = materialSoportePlantar.EVA,
                componentes = materialSoportePlantar.componentes,
                otros = materialSoportePlantar.otros,
                propileno = materialSoportePlantar.propileno,
                resinas = materialSoportePlantar.resinas,
                tratamiento = mapTratamiento == true ? materialSoportePlantar.tratamiento?.ModelToEntity() : null
            };
        }
    }
}
