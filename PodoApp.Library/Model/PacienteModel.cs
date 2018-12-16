using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Model
{
    public class PacienteModel
    {
        public Guid idPaciente { get; set; }

        public string medicacionHabitual { get; set; }

        public string observacion { get; set; }

        public Guid? id_podologo { get; set; }

        public Guid? id_historial_clinico { get; set; }

        public Guid? id_persona { get; set; }

        public ICollection<ConsultaModel> consulta { get; set; }

        public ICollection<PrimeraVisitaModel> primeraVisita { get; set; }
    }
}
