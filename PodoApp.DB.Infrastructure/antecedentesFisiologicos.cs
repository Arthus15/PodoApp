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
    
    public partial class antecedentesFisiologicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public antecedentesFisiologicos()
        {
            this.historialClinico = new HashSet<historialClinico>();
        }
    
        public System.Guid idAFisiologico { get; set; }
        public bool andador { get; set; }
        public bool tacata { get; set; }
        public Nullable<int> inicioDeambulacion { get; set; }
        public string habitosPosturales { get; set; }
        public Nullable<int> cambiosPonderales { get; set; }
        public bool zurdo { get; set; }
        public bool diestro { get; set; }
        public bool ambidiestro { get; set; }
        public string otros { get; set; }
        public bool partoCabeza { get; set; }
        public bool partoNalgas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<historialClinico> historialClinico { get; set; }
    }
}
