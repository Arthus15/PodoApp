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
    
    public partial class bipedestacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bipedestacion()
        {
            this.estudioOrtopodologico = new HashSet<estudioOrtopodologico>();
        }
    
        public System.Guid idBipedestacion { get; set; }
        public string visionAnterior { get; set; }
        public string visionPosterior { get; set; }
        public string visionLateral { get; set; }
        public bool basculaEscapular { get; set; }
        public bool basculaPelvica { get; set; }
        public Nullable<double> balculaPelvicaMM { get; set; }
        public bool posicionEscoliotica { get; set; }
        public bool testAdams { get; set; }
        public string testAdamsGiro { get; set; }
        public bool pruebaIsquiotibilaesCortos { get; set; }
        public bool genuFisiologico { get; set; }
        public bool genuValgo { get; set; }
        public Nullable<double> genuValgoDim { get; set; }
        public bool genuVaro { get; set; }
        public Nullable<double> genuVaroDic { get; set; }
        public bool tibiasFisiologicas { get; set; }
        public bool tibiasValgas { get; set; }
        public bool tibiasVaras { get; set; }
        public bool pieRadioInsuficiente { get; set; }
        public string pieRadioInsucienteNotas { get; set; }
        public bool pieSobrecargaMeta { get; set; }
        public string pieSobrecargaMetaNotas { get; set; }
        public Nullable<System.Guid> id_retropie { get; set; }
        public Nullable<System.Guid> id_antepie { get; set; }
        public Nullable<System.Guid> id_fpi { get; set; }
    
        public virtual antepie antepie { get; set; }
        public virtual FPI FPI { get; set; }
        public virtual retropie retropie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<estudioOrtopodologico> estudioOrtopodologico { get; set; }
    }
}