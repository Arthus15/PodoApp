using System;

namespace PodoApp.Library.Model
{
    public class PodologoModel
    {
        public Guid idPodologo { get; set; }

        public string idTitulo { get; set; }

        public string email { get; set; }

        public Guid? id_persona { get; set; }
    }
}