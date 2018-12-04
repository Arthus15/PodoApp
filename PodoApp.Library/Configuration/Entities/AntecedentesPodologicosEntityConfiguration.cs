using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.Entities
{
    public class AntecedentesPodologicosEntityConfiguration : EntityTypeConfiguration<AntecedentesPodologicos>
    {
        public AntecedentesPodologicosEntityConfiguration()
        {
            this.HasMany(e => e.historialClinico)
                .WithOptional(e => e.antecedentesPodologicos)
                .HasForeignKey(e => e.id_ant_podologicos);
        }
    }
}
