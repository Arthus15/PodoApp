using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class PodologoMapper
    {
        public static PodologoModel EntityToModel(this Podologo podologo)
        {
            return new PodologoModel
            {
                idPodologo = podologo.idPodologo,
                id_persona = podologo.id_persona,
                email = podologo.email,
                idTitulo = podologo.idTitulo
            };
        }
    }
}
