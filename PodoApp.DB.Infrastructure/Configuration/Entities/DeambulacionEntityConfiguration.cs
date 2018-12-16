using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class DeambulacionEntityConfiguration : EntityTypeConfiguration<Deambulacion>
    {
        public DeambulacionEntityConfiguration()
        {
            this.HasMany(e => e.estudioOrtopodologico)
                 .WithOptional(e => e.deambulacion)
                 .HasForeignKey(e => e.id_deambulacion);
        }
    }
}
