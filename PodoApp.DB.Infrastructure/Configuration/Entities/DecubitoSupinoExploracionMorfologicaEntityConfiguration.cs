using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    class DecubitoSupinoExploracionMorfologicaEntityConfiguration : EntityTypeConfiguration<DecubitoSupinoExploracionMorfologica>
    {
        public DecubitoSupinoExploracionMorfologicaEntityConfiguration()
        {
            this.HasMany(e => e.estudioOrtopodologico)
                .WithOptional(e => e.decubitoSupinoExploracionMorfologica)
                .HasForeignKey(e => e.id_dse_morfologico);
        }
    }
}
