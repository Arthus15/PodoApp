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
    
    public partial class sedestacionExploracionArticular
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sedestacionExploracionArticular()
        {
            this.estudioOrtopodologico = new HashSet<estudioOrtopodologico>();
        }
    
        public System.Guid idEArticularPieIzdo { get; set; }
        public System.Guid idEArticularPieDcho { get; set; }
        public Nullable<double> anteversionFemoralNinosIzda { get; set; }
        public Nullable<double> anteversionFemoralNinosDcha { get; set; }
        public Nullable<double> anteversionFemoralAdultosIzda { get; set; }
        public Nullable<double> anteversionFemoralAdultosDcha { get; set; }
        public Nullable<double> anguloTorsionBimaleolarIzda { get; set; }
        public Nullable<double> anguloTorsionBimaleolarDcha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<estudioOrtopodologico> estudioOrtopodologico { get; set; }
    }
}
