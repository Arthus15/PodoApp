using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Repositories
{
    public interface IConsultaRepository : IBaseRepository<ConsultaModel>
    {
        List<ConsultaModel> GetAllByPacienteId(Guid idPaciente);

        ConsultaModel Get(Guid idConsulta);
    }
}
