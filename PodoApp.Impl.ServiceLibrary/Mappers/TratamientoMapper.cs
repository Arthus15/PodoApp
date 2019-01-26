using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class TratamientoMapper
    {
        public static TratamientoDto ModelToDto(this TratamientoModel tratamiento)
        {
            return new TratamientoDto
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

        public static TratamientoModel DtoToModel(this TratamientoDto tratamiento)
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
    }
}
