using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.Entities
{
    public class DecubitoSupinoPulsosTipoEntityConfiguration : EntityTypeConfiguration<DecubitoSupinoPulsosTipo>
    {
        public DecubitoSupinoPulsosTipoEntityConfiguration()
        {
            this.Property(e => e.debil)
                .IsFixedLength();

            this.HasMany(e => e.decubitoSupinoPulsos)
                .WithOptional(e => e.decubitoSupinoPulsosTipo)
                .HasForeignKey(e => e.id_pulsos_tipo);
        }
    }
}
