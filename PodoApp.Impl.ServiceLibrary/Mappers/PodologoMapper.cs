using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class PodologoMapper
    {
        public static PodologoDto ModelToDto(this PodologoModel podologo)
        {
            return new PodologoDto
            {
                idPodologo = podologo.idPodologo,
                id_persona = podologo.id_persona,
                email = podologo.email,
                idTitulo = podologo.idTitulo
            };
        }
    }
}
