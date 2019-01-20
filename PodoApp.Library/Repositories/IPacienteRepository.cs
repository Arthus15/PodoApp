using PodoApp.Library.Model;
using System;
using System.Collections.Generic;

namespace PodoApp.Library.Repositories
{
    public interface IPacienteRepository : IBaseRepository<PacienteModel>
    {
        IEnumerable<PacienteModel> GetAll();
        PacienteModel GetById(object id);

        bool Exists(Guid idPaciente);
    }
}
