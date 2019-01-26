using PodoApp.Contracts.ServiceLibrary.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.DiagnosticoTratamiento.Models
{
    public class FormDiagnosticoTratamiento
    {
        public Guid IdPaciente { get; set; }

        // Diagnostico

        public Guid IdDiagnostico { get; set; }

        [DisplayName("Anotaciones")]
        [Required()]
        public string Anotaciones { get; set; }

        // Tratamiento
        public Guid? IdTratamiento { get; set; }

        [DisplayName("Físico")]
        public bool Fisico { get; set; }

        [DisplayName("Ejercicios Propioceptivos")]
        public string EjerciciosPropioceptivos { get; set; }

        [DisplayName("Farmacológico")]
        public bool Farmacologico { get; set; }

        [DisplayName("Quiropodológico")]
        public bool Quiropodologico { get; set; }

        [DisplayName("Ortosis Digital")]
        public bool Ortosis { get; set; }

        [DisplayName("Tipo Ortosis Digital")]
        public string TipoOrtosis { get; set; }

        [DisplayName("Soporte Plantar")]
        public bool SoportePlantar { get; set; }

        [DisplayName("Vendaje Funcional")]
        public bool VendajeFuncional { get; set; }

        [DisplayName("Preventivo")]
        public bool Preventivo { get; set; }

        [DisplayName("Preventivo Observaciones")]
        public string PreventivoObservaciones { get; set; }

        [DisplayName("Calzadoterapia")]
        public bool Calzadoterapia { get; set; }

        [DisplayName("Otros")]
        public string Otros { get; set; }

        // Material Soporte Plantar

        public Guid? IdMaterialSoporte { get; set; }

        [DisplayName("TAD")]
        public bool Tad { get; set; }

        [DisplayName("Resinas")]
        public bool Resinas { get; set; }

        [DisplayName("EVA")]
        public bool Eva { get; set; }

        [DisplayName("Propileno")]
        public bool Propileno { get; set; }

        [DisplayName("Componentes")]
        public string Componentes { get; set; }

        [DisplayName("Otros")]
        public string OtrosComentarios { get; set; }

        public Guid? IdPrimeraVisita { get; set; }

        public FormDiagnosticoTratamiento()
        {

        }

        public FormDiagnosticoTratamiento(DiagnosticoDto diagnostico, MaterialSoportePlantarDto materialSoportePlantar)
        {
            IdDiagnostico = diagnostico.idDiagnostico;
            Anotaciones = diagnostico.anotaciones;

            // tratamiento
            IdTratamiento = diagnostico.id_tratamiento;
            Fisico = diagnostico.Tratamiento.fisico;
            EjerciciosPropioceptivos = diagnostico.Tratamiento.ejerciciosPropioceptivos;
            Farmacologico = diagnostico.Tratamiento.farmacologico;
            Quiropodologico = diagnostico.Tratamiento.quiropodologico;
            Ortosis = diagnostico.Tratamiento.ortosisDigital;
            TipoOrtosis = diagnostico.Tratamiento.ortosisDigitalTipo;
            SoportePlantar = diagnostico.Tratamiento.soportePlantar;
            VendajeFuncional = diagnostico.Tratamiento.vendajeFuncional;
            Preventivo = diagnostico.Tratamiento.preventivo;
            PreventivoObservaciones = diagnostico.Tratamiento.preventivoObservacion;
            Calzadoterapia = diagnostico.Tratamiento.calzadoterapia;
            Otros = diagnostico.Tratamiento.otros;

            // material soporte plantar
            Tad = materialSoportePlantar.TAD;
            Resinas = materialSoportePlantar.resinas;
            Eva = materialSoportePlantar.EVA;
            Propileno = materialSoportePlantar.propileno;
            Componentes = materialSoportePlantar.componentes;
            OtrosComentarios = materialSoportePlantar.otros;
            IdPrimeraVisita = diagnostico.id_primera_visita;
            IdMaterialSoporte = materialSoportePlantar.idMaterialSoportePlantar;
        }
    }
}