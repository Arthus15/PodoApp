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
    
    public partial class paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public paciente()
        {
            this.consulta = new HashSet<consulta>();
            this.primeraVisita = new HashSet<primeraVisita>();
        }
    
        public System.Guid idPaciente { get; set; }
        public string medicacionHabitual { get; set; }
        public string observacion { get; set; }
        public Nullable<System.Guid> id_podologo { get; set; }
        public Nullable<System.Guid> id_historial_clinico { get; set; }
        public Nullable<System.Guid> id_persona { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<consulta> consulta { get; set; }
        public virtual historialClinico historialClinico { get; set; }
        public virtual persona persona { get; set; }
        public virtual podologo podologo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<primeraVisita> primeraVisita { get; set; }
    }
}