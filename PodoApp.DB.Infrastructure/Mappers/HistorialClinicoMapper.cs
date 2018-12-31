using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class HistorialClinicoMapper
    {
        public static HistorialClinicoModel EntityToModel(this HistorialClinico historialClinico)
        {
            return new HistorialClinicoModel
            {
                idHistorialClinico = historialClinico.idHistorialClinico,
                id_ant_familiares = historialClinico.id_ant_familiares,
                id_ant_fisiologicos = historialClinico.id_ant_fisiologicos,
                id_ant_patologicos = historialClinico.id_ant_patologicos,
                id_ant_podologicos = historialClinico.id_ant_podologicos,
                numeroHistorialClinico = historialClinico.numeroHistorialClinico,
                antecedentesFamiliares = historialClinico.antecedentesFamiliares?.EntityToModel(),
                antecedentesFisiologicos = historialClinico.antecedentesFisiologicos?.EntityToModel(),
                antecedentesPatologicos = historialClinico.antecedentesPatologicos?.EntityToModel(),
                antecedentesPodologicos = historialClinico.antecedentesPodologicos?.EntityToModel(),
                id_estudio = historialClinico.id_estudio
            };
        }

        public static HistorialClinico ModelToEntity(this HistorialClinicoModel historialClinico)
        {
            return new HistorialClinico
            {
                idHistorialClinico = historialClinico.idHistorialClinico,
                id_ant_familiares = historialClinico.id_ant_familiares,
                id_ant_fisiologicos = historialClinico.id_ant_fisiologicos,
                id_ant_patologicos = historialClinico.id_ant_patologicos,
                id_ant_podologicos = historialClinico.id_ant_podologicos,
                numeroHistorialClinico = historialClinico.numeroHistorialClinico,
                id_estudio = historialClinico.id_estudio
            };
        }

        public static void MapChanges(this HistorialClinico source, ref HistorialClinico dest)
        {   
            if(source.numeroHistorialClinico != null)
            {
                dest.numeroHistorialClinico = source.numeroHistorialClinico;
            }
            dest.id_ant_familiares = source.id_ant_familiares;
            dest.id_ant_fisiologicos = source.id_ant_fisiologicos;
            dest.id_ant_patologicos = source.id_ant_patologicos;
            dest.id_ant_podologicos = source.id_ant_podologicos;
        }
    }
}
