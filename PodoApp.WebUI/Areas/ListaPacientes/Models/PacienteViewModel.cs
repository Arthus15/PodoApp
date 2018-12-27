using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.ListaPacientes.Models
{
    public class PacienteViewModel
    {
        public Guid idPaciente { get; set; }

        public string medicacionHabitual { get; set; }

        public string observacion { get; set; }

        public Guid? id_podologo { get; set; }

        public Guid? id_historial_clinico { get; set; }

        public Guid? id_persona { get; set; }

        // Person Data

        public string nombre { get; set; }

        public string dni { get; set; }

        // Clinic Historical

        public Guid? IdAntFamiliares { get; set; }

        public string numeroHistorialClinico { get; set; }

        // First Visit
        
        public Guid? idPrimeraVisita { get; set; }

        // Diagnostic

        public Guid? idDiagnostico { get; set; }

    }
}