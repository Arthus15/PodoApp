using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.Entities
{
    public class SedestacionExploracionMuscularEntityConfiguration : EntityTypeConfiguration<SedestacionExploracionMuscular>
    {
        public SedestacionExploracionMuscularEntityConfiguration()
        {
            this.HasMany(e => e.estudioOrtopodologico)
                .WithOptional(e => e.sedestacionExploracionMuscular)
                .HasForeignKey(e => new { e.id_se_muscular_izdo, e.id_se_muscular_dcho });
        }
    }
}
