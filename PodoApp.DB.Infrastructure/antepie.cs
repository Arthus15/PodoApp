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
    
    public partial class antepie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public antepie()
        {
            this.bipedestacion = new HashSet<bipedestacion>();
        }
    
        public System.Guid idAntepie { get; set; }
        public bool varo { get; set; }
        public bool supinado { get; set; }
        public bool valgo { get; set; }
        public bool neutro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bipedestacion> bipedestacion { get; set; }
    }
}
