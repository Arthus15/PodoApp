using PodoApp.Contracts.ServiceLibrary.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Contracts.ServiceLibrary.Interfaces
{
   public interface IPacienteService
    {
        void Insert(PacienteDto paciente);
        PacienteDto Get(Guid id);

        void Update(PacienteDto paciente);

        bool Exists(Guid idPaciente);
    }
}
