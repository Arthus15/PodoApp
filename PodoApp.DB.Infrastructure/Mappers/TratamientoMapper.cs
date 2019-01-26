using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class TratamientoMapper
    {
        public static TratamientoModel EntityToModel(this Tratamiento tratamiento)
        {
            return new TratamientoModel
            {
                idTratamiento = tratamiento.idTratamiento,
                calzadoterapia = tratamiento.calzadoterapia,
                ejerciciosPropioceptivos = tratamiento.ejerciciosPropioceptivos,
                farmacologico = tratamiento.farmacologico,
                fisico = tratamiento.fisico,
                ortosisDigital = tratamiento.ortosisDigital,
                ortosisDigitalTipo = tratamiento.ortosisDigitalTipo,
                otros = tratamiento.otros,
                preventivo = tratamiento.preventivo,
                preventivoObservacion = tratamiento.preventivoObservacion,
                quiropodologico = tratamiento.quiropodologico,
                vendajeFuncional = tratamiento.vendajeFuncional                
            };
        }

        public static Tratamiento ModelToEntity(this TratamientoModel tratamiento)
        {
            return new Tratamiento
            {
                idTratamiento = tratamiento.idTratamiento,
                calzadoterapia = tratamiento.calzadoterapia,
                ejerciciosPropioceptivos = tratamiento.ejerciciosPropioceptivos,
                farmacologico = tratamiento.farmacologico,
                fisico = tratamiento.fisico,
                ortosisDigital = tratamiento.ortosisDigital,
                ortosisDigitalTipo = tratamiento.ortosisDigitalTipo,
                otros = tratamiento.otros,
                preventivo = tratamiento.preventivo,
                preventivoObservacion = tratamiento.preventivoObservacion,
                quiropodologico = tratamiento.quiropodologico,
                vendajeFuncional = tratamiento.vendajeFuncional
            };
        }
    }
}
