using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class DecubitoPronoExploracionArticularEntityConfiguration : EntityTypeConfiguration<DecubitoPronoExploracionArticular>
    {
        public DecubitoPronoExploracionArticularEntityConfiguration()
        {
            this.HasMany(e => e.estudioOrtopodologico)
                .WithOptional(e => e.decubitoPronoExploracionArticular)
                .HasForeignKey(e => new { e.id_dp_articular_izdo, e.id_dp_articular_dcho });
        }
    }
}
