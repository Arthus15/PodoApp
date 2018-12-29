using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class HistorialClinicoMapper
    {
        public static HistorialClinicoDto ModelToDto(this HistorialClinicoModel historialClinico)
        {
            var antecedentesFamiliares = historialClinico?.antecedentesFamiliares.ModelToDto();
            var antecedentesFisiologicos = historialClinico?.antecedentesFisiologicos.ModelToDto();
            var antecedentesPatologicos = historialClinico?.antecedentesPatologicos.ModelToDto();
            var antecedentesPodologicos = historialClinico?.antecedentesPodologicos.ModelToDto();

            return new HistorialClinicoDto
            {
                idHistorialClinico = historialClinico.idHistorialClinico,
                id_ant_familiares = historialClinico?.id_ant_familiares,
                id_ant_fisiologicos = historialClinico?.id_ant_fisiologicos,
                id_ant_patologicos = historialClinico?.id_ant_patologicos,
                id_ant_podologicos = historialClinico?.id_ant_podologicos,
                numeroHistorialClinico = historialClinico.numeroHistorialClinico,
                id_estudio = historialClinico.id_estudio,
                antecedentesFamiliares = antecedentesFamiliares,
                antecedentesFisiologicos = antecedentesFisiologicos,
                antecedentesPodologicos = antecedentesPodologicos,
                antecedentesPatologicos = antecedentesPatologicos
                
            };
        }
        
        public static HistorialClinicoModel DtoToModel(this HistorialClinicoDto historialClinico)
        {
            var antecedentesFamiliares = historialClinico?.antecedentesFamiliares.DtoToModel();
            var antecedentesFisiologicos = historialClinico?.antecedentesFisiologicos.DtoToModel();
            var antecedentesPatologicos = historialClinico?.antecedentesPatologicos.DtoToModel();
            var antecedentesPodologicos = historialClinico?.antecedentesPodologicos.DtoToModel();

            return new HistorialClinicoModel
            {
                idHistorialClinico = historialClinico.idHistorialClinico,
                id_ant_familiares = historialClinico?.id_ant_familiares,
                id_ant_fisiologicos = historialClinico?.id_ant_fisiologicos,
                id_ant_patologicos = historialClinico?.id_ant_patologicos,
                id_ant_podologicos = historialClinico?.id_ant_podologicos,
                numeroHistorialClinico = historialClinico.numeroHistorialClinico,
                id_estudio = historialClinico.id_estudio,
                antecedentesFamiliares = antecedentesFamiliares,
                antecedentesFisiologicos = antecedentesFisiologicos,
                antecedentesPodologicos = antecedentesPodologicos,
                antecedentesPatologicos = antecedentesPatologicos

            };
        }
    }
}
