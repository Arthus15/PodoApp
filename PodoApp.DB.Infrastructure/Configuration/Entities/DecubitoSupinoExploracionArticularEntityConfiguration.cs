using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
   public class DecubitoSupinoExploracionArticularEntityConfiguration : EntityTypeConfiguration<DecubitoSupinoExploracionArticular>
    {
        public DecubitoSupinoExploracionArticularEntityConfiguration()
        {
            this.HasMany(e => e.estudioOrtopodologico)
                .WithOptional(e => e.decubitoSupinoExploracionArticular)
                .HasForeignKey(e => new { e.id_dse_articular_izdo, e.id_dse_articular_dcho });
        }
    }
}
