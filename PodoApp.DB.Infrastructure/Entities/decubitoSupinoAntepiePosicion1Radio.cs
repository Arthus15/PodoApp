namespace PodoApp.DB.Infrastructure.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DecubitoSupinoAntepiePosicion1Radio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DecubitoSupinoAntepiePosicion1Radio()
        {
            decubitoSupinoExploracionArticular = new HashSet<DecubitoSupinoExploracionArticular>();
        }

        [Key]
        public Guid idPosicion1radio { get; set; }

        public bool dorsalrFlex { get; set; }

        public bool plantarFlex { get; set; }

        public bool neutro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<DecubitoSupinoExploracionArticular> decubitoSupinoExploracionArticular { get; set; }
    }
}
