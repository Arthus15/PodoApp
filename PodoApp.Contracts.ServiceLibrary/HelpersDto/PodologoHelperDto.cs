using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Contracts.ServiceLibrary.HelpersDto
{
    public class PodologoHelperDto
    {
        public Guid? IdPersona { get; set; }
        public Guid IdPodologo { get; set; }
        public string Nombre { get; set; }
    }
}
