using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
   public class AnguloFickEntityConfiguration : EntityTypeConfiguration<AnguloFick>
    {
        public AnguloFickEntityConfiguration()
        {
            this.ToTable("anguloFick");

            this.HasMany(e => e.visionFrontal)
                .WithOptional(e => e.anguloFick)
                .HasForeignKey(e => e.id_anguloFick);
        }
    }
}
