using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.WebUI.Areas.Consulta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.Consulta.Mapper
{
    public static class FormConsultaMapper
    {
        private static Guid newIdConsulta;
        public static ConsultaDto FormConsultaToDto(this FormConsulta form, bool newForm = true)
        {
            newIdConsulta = newForm == false ? (Guid)form.IdConsulta : Guid.NewGuid();

            return new ConsultaDto
            {
                idConsulta = newIdConsulta,
                id_paciente = form.IdPaciente,
                id_podologo = form.IdPodologo,
                fecha = form.Fecha,
                descripcion = form.Descripcion
            };
        }

        public static FormConsulta DtoToFormConsulta(this ConsultaDto form)
        {
            return new FormConsulta
            {
                IdConsulta = form.idConsulta,
                IdPaciente = form.id_paciente,
                IdPodologo = form.id_podologo,
                Fecha = form.fecha,
                Descripcion = form.descripcion
            };
        }
    }
}