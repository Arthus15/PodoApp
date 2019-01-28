using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.Consulta.Models
{
    public class FormConsulta
    {
        public Guid? IdConsulta { get; set; }

        public Guid? IdPaciente { get; set; }

        public Guid? IdPodologo { get; set; }

        [DisplayName("Fecha de la consulta")]
        public DateTime? Fecha { get; set; }

        [DisplayName("Descripción")]
        public String Descripcion { get; set; }
    }
}