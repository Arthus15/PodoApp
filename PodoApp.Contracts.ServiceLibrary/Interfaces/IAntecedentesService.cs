using PodoApp.Contracts.ServiceLibrary.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Contracts.ServiceLibrary.Interfaces
{
    public interface IAntecedentesService
    {
        void Insert(HistorialClinicoDto historialClinico);
    }
}
