using PodoApp.Library.Model;
using System.Collections.Generic;

namespace PodoApp.Library.Repositories
{
    public interface IPacienteRepository : IBaseRepository<PacienteModel>
    {
        IEnumerable<PacienteModel> GetAll();
    }
}
