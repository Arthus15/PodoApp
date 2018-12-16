using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class SedestacionExploracionArticularEntityConfiguration : EntityTypeConfiguration<SedestacionExploracionArticular>
    {
        public SedestacionExploracionArticularEntityConfiguration()
        {
            this.HasMany(e => e.estudioOrtopodologico)
                .WithOptional(e => e.sedestacionExploracionArticular)
                .HasForeignKey(e => new { e.id_se_articular_izdo, e.id_se_articular_dcho });

        }
    }
}
