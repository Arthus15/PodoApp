using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.EntitiesConfiguration
{
    public class HistorialClinicoEntityConfiguration : EntityTypeConfiguration<HistorialClinico>
    {
        public HistorialClinicoEntityConfiguration()
        {
            this.Property(e => e.numeroHistorialClinico)
                .IsFixedLength();

            this.HasMany(e => e.paciente)
                .WithOptional(e => e.historialClinico)
                .HasForeignKey(e => e.id_historial_clinico);
        }
    }
}
