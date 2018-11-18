using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.EntitiesConfiguration
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
