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
    
    public partial class decubitoSupinoPulsosTipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public decubitoSupinoPulsosTipo()
        {
            this.decubitoSupinoPulsos = new HashSet<decubitoSupinoPulsos>();
        }
    
        public System.Guid idPulsosTipo { get; set; }
        public bool presente { get; set; }
        public bool ausente { get; set; }
        public string debil { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<decubitoSupinoPulsos> decubitoSupinoPulsos { get; set; }
    }
}