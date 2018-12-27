using PodoApp.Contracts.ServiceLibrary.Dto;
using System.Collections.Generic;

namespace PodoApp.Contracts.ServiceLibrary.Interfaces
{
    public interface IListaPacienteService
    {
        IEnumerable<PacienteDto> GetAll();
    }
}
