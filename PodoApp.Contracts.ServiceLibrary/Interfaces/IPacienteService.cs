using PodoApp.Contracts.ServiceLibrary.Dto;
using System.Collections.Generic;

namespace PodoApp.Contracts.ServiceLibrary.Interfaces
{
    public interface IPacienteService
    {
        IEnumerable<PacienteDto> GetAll();
    }
}
