using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
   public class RetropieEntityConfiguration : EntityTypeConfiguration<Retropie>
    {
        public RetropieEntityConfiguration()
        {
            this.HasMany(e => e.bipedestacion)
                .WithOptional(e => e.retropie)
                .HasForeignKey(e => e.id_retropie);
        }
    }
}
