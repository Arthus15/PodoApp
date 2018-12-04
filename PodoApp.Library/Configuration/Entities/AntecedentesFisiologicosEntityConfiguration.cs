using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.Entities
{
    public class AntecedentesFisiologicosEntityConfiguration : EntityTypeConfiguration<AntecedentesFisiologicos>
    {
        public AntecedentesFisiologicosEntityConfiguration()
        {
            this.HasMany(e => e.historialClinico)
                .WithOptional(e => e.antecedentesFisiologicos)
                .HasForeignKey(e => e.id_ant_fisiologicos);
        }
    }
}
