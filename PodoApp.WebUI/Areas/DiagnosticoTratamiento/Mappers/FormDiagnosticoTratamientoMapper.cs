using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.WebUI.Areas.DiagnosticoTratamiento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.DiagnosticoTratamiento.Mappers
{
    public static class FormDiagnosticoTratamientoMapper
    {
        private static Guid nuevoIdDiagnostico;
        private static Guid nuevoIdTratamiento;
        private static Guid nuevoIdMaterial;

        public static List<object> FormToDto(this FormDiagnosticoTratamiento form, bool newForm = false)
        {
            if (newForm)
            {
                nuevoIdDiagnostico = Guid.NewGuid();
                nuevoIdMaterial = Guid.NewGuid();
                nuevoIdTratamiento = Guid.NewGuid();
            }
            else
            {
                nuevoIdDiagnostico = form.IdDiagnostico;
                nuevoIdMaterial = (Guid)form.IdMaterialSoporte;
                nuevoIdTratamiento = (Guid)form.IdTratamiento;
            }

            TratamientoDto tratamiento = new TratamientoDto
            {
                idTratamiento = nuevoIdTratamiento,
                fisico = form.Fisico,
                ejerciciosPropioceptivos = form.EjerciciosPropioceptivos,
                farmacologico = form.Farmacologico,
                quiropodologico = form.Quiropodologico,
                ortosisDigital = form.Ortosis,
                ortosisDigitalTipo = form.TipoOrtosis,
                soportePlantar = form.SoportePlantar,
                vendajeFuncional = form.VendajeFuncional,
                preventivo = form.Preventivo,
                preventivoObservacion = form.PreventivoObservaciones,
                calzadoterapia = form.Calzadoterapia,
                otros = form.Otros
            };

            DiagnosticoDto diagnostico = new DiagnosticoDto
            {
                idDiagnostico = nuevoIdDiagnostico,
                anotaciones = form.Anotaciones,
                id_primera_visita = form.IdPrimeraVisita,
                id_tratamiento = nuevoIdTratamiento,
                Tratamiento = tratamiento
            };

            MaterialSoportePlantarDto materialSoportePlantar = new MaterialSoportePlantarDto
            {
                idMaterialSoportePlantar = nuevoIdMaterial,
                TAD = form.Tad,
                resinas = form.Resinas,
                EVA = form.Eva,
                propileno = form.Propileno,
                componentes = form.Componentes,
                otros = form.Otros,
                id_tratamiento = nuevoIdTratamiento,
                tratamiento = tratamiento
            };

            return new List<object>() { diagnostico, materialSoportePlantar };
        }
    }
}