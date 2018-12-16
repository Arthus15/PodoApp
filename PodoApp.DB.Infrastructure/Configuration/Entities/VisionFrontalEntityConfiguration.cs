using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class VisionFrontalEntityConfiguration : EntityTypeConfiguration<VisionFrontal>
    {
        public VisionFrontalEntityConfiguration()
        {
            this.HasMany(e => e.estudioOrtopodologico)
                .WithOptional(e => e.visionFrontal)
                .HasForeignKey(e => e.id_adv_frontal);
        }
    }
}
