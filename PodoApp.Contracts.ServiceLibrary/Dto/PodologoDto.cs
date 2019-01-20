using System;

namespace PodoApp.Contracts.ServiceLibrary.Dto
{
    public class PodologoDto
    {
        public Guid idPodologo { get; set; }

        public string idTitulo { get; set; }

        public string email { get; set; }

        public Guid? id_persona { get; set; }
    }
}