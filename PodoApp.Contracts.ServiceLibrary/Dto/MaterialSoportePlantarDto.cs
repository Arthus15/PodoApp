using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Contracts.ServiceLibrary.Dto
{
    public class MaterialSoportePlantarDto
    {
        public Guid idMaterialSoportePlantar { get; set; }
        public bool TAD { get; set; }
        public bool resinas { get; set; }
        public bool EVA { get; set; }
        public bool propileno { get; set; }
        public string componentes { get; set; }
        public string otros { get; set; }
        public Guid? id_tratamiento { get; set; }

        public virtual TratamientoDto tratamiento { get; set; }
    }
}
