//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PodoApp.DB.Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class tratamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tratamiento()
        {
            this.diagnostico = new HashSet<diagnostico>();
            this.materialSoportePlantar = new HashSet<materialSoportePlantar>();
        }
    
        public System.Guid idTratamiento { get; set; }
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diagnostico> diagnostico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<materialSoportePlantar> materialSoportePlantar { get; set; }
    }
}
