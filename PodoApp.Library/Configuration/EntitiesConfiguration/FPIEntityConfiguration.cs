using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.EntitiesConfiguration
{
    public class FPIEntityConfiguration : EntityTypeConfiguration<FPI>
    {
        public FPIEntityConfiguration()
        {
            this.HasMany(e => e.bipedestacion)
                .WithOptional(e => e.FPI)
                .HasForeignKey(e => e.id_fpi);
        }
    }
}
