using PodoApp.Contracts.ServiceLibrary.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Contracts.ServiceLibrary.Interfaces
{
    public interface IDiagnosticoTratamientoService
    {
        void Insert(DiagnosticoDto diagnostico, MaterialSoportePlantarDto materialSoportePlantar);

        List<object> Get(Guid idDiagnostico);

        void Update(DiagnosticoDto diagnostico, MaterialSoportePlantarDto materialSoportePlantar);
    }
}
