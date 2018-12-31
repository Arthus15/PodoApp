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
            return new HistorialClinicoDto
            {
                idHistorialClinico = historialClinico.idHistorialClinico,
                id_ant_familiares = historialClinico?.id_ant_familiares,
                id_ant_fisiologicos = historialClinico?.id_ant_fisiologicos,
                id_ant_patologicos = historialClinico?.id_ant_patologicos,
                id_ant_podologicos = historialClinico?.id_ant_podologicos,
                numeroHistorialClinico = historialClinico.numeroHistorialClinico,
                id_estudio = historialClinico.id_estudio,
                antecedentesFamiliares = historialClinico.antecedentesFamiliares?.ModelToDto(),
                antecedentesFisiologicos = historialClinico.antecedentesFisiologicos?.ModelToDto(),
                antecedentesPatologicos = historialClinico.antecedentesPatologicos?.ModelToDto(),
                antecedentesPodologicos = historialClinico.antecedentesPodologicos?.ModelToDto()

            };
        }

        public static HistorialClinicoModel DtoToModel(this HistorialClinicoDto historialClinico)
        {
            return new HistorialClinicoModel
            {
                idHistorialClinico = historialClinico.idHistorialClinico,
                id_ant_familiares = historialClinico?.id_ant_familiares,
                id_ant_fisiologicos = historialClinico?.id_ant_fisiologicos,
                id_ant_patologicos = historialClinico?.id_ant_patologicos,
                id_ant_podologicos = historialClinico?.id_ant_podologicos,
                numeroHistorialClinico = historialClinico.numeroHistorialClinico,
                id_estudio = historialClinico.id_estudio,
                antecedentesFamiliares = historialClinico.antecedentesFamiliares?.DtoToModel(),
                antecedentesFisiologicos = historialClinico.antecedentesFisiologicos?.DtoToModel(),
                antecedentesPatologicos = historialClinico.antecedentesPatologicos?.DtoToModel(),
                antecedentesPodologicos = historialClinico.antecedentesPodologicos?.DtoToModel()

            };
        }
    }
}
