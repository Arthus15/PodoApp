namespace PodoApp.Library.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bipedestacion")]
    public partial class Bipedestacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bipedestacion()
        {
            estudioOrtopodologico = new HashSet<EstudioOrtopodologico>();
        }

        [Key]
        public Guid idBipedestacion { get; set; }

        public string visionAnterior { get; set; }

        public string visionPosterior { get; set; }

        public string visionLateral { get; set; }

        public bool basculaEscapular { get; set; }

        public bool basculaPelvica { get; set; }

        public double? balculaPelvicaMM { get; set; }

        public bool posicionEscoliotica { get; set; }

        public bool testAdams { get; set; }

        public string testAdamsGiro { get; set; }

        public bool pruebaIsquiotibilaesCortos { get; set; }

        public bool genuFisiologico { get; set; }

        public bool genuValgo { get; set; }

        public double? genuValgoDim { get; set; }

        public bool genuVaro { get; set; }

        public double? genuVaroDic { get; set; }

        public bool tibiasFisiologicas { get; set; }

        public bool tibiasValgas { get; set; }

        public bool tibiasVaras { get; set; }

        public bool pieRadioInsuficiente { get; set; }

        public string pieRadioInsucienteNotas { get; set; }

        public bool pieSobrecargaMeta { get; set; }

        public string pieSobrecargaMetaNotas { get; set; }

        public Guid? id_retropie { get; set; }

        public Guid? id_antepie { get; set; }

        public Guid? id_fpi { get; set; }

        public virtual Antepie antepie { get; set; }

        public virtual FPI FPI { get; set; }

        public virtual Retropie retropie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstudioOrtopodologico> estudioOrtopodologico { get; set; }
    }
}
