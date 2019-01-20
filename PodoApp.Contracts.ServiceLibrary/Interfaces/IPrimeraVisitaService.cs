using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.HelpersDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Contracts.ServiceLibrary.Interfaces
{
    public interface IPrimeraVisitaService
    {
        void Insert(PrimeraVisitaDto primeraVisita);
        List<PodologoHelperDto> GetPodologos();
        PrimeraVisitaDto Get(Guid id);
        void Update(PrimeraVisitaDto primeraVisita);
    }
}
