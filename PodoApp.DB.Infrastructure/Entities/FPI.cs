namespace PodoApp.DB.Infrastructure.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FPI")]
    public partial class FPI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FPI()
        {
            bipedestacion = new HashSet<Bipedestacion>();
        }

        [Key]
        public Guid idFPI { get; set; }

        public int? palpacionEstragaloIzda { get; set; }

        public int? palpacionEstragaloDcha { get; set; }

        public int? curvaturaMaleolarIzda { get; set; }

        public int? curvaturaMaleolarDcha { get; set; }

        public int? posicionCalcaneoIzda { get; set; }

        public int? posicionCalcaneoDcha { get; set; }

        public int? prominenciaArticulacionIzda { get; set; }

        public int? prominenciaArticulacionDcha { get; set; }

        public int? alturaYcongruenciaIzda { get; set; }

        public int? alturaYcongruenciaDcha { get; set; }

        public int? abduccionYaduccionIzda { get; set; }

        public int? abduccionYaduccionDcha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bipedestacion> bipedestacion { get; set; }
    }
}
