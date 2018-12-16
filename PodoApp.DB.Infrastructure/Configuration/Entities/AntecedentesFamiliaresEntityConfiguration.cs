using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class AntecedentesFamiliaresEntityConfiguration : EntityTypeConfiguration<AntecedentesFamiliares>
    {
        public AntecedentesFamiliaresEntityConfiguration()
        {
            this.HasMany(e => e.historialClinico)
            .WithOptional(e => e.antecedentesFamiliares)
            .HasForeignKey(e => e.id_ant_familiares);
        }
    }
}
