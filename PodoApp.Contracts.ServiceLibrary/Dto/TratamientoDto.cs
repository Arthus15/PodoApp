using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Contracts.ServiceLibrary.Dto
{
    public class TratamientoDto
    {
        public Guid idTratamiento { get; set; }
        public bool fisico { get; set; }
        public string ejerciciosPropioceptivos { get; set; }
        public bool farmacologico { get; set; }
        public bool quiropodologico { get; set; }
        public bool ortosisDigital { get; set; }
        public string ortosisDigitalTipo { get; set; }
        public bool soportePlantar { get; set; }
        public bool vendajeFuncional { get; set; }
        public bool preventivo { get; set; }
        public string preventivoObservacion { get; set; }
        public bool calzadoterapia { get; set; }
        public string otros { get; set; }
    }
}
