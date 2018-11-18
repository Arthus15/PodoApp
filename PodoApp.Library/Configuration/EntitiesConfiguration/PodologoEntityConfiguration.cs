using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.EntitiesConfiguration
{
    public class PodologoEntityConfiguration : EntityTypeConfiguration<Podologo>
    {
        public PodologoEntityConfiguration()
        {
            this.HasMany(e => e.consulta)
                .WithOptional(e => e.podologo)
                .HasForeignKey(e => e.id_podologo);

            this.HasMany(e => e.paciente)
                .WithOptional(e => e.podologo)
                .HasForeignKey(e => e.id_podologo)
                .WillCascadeOnDelete();

            this.HasMany(e => e.primeraVisita)
                .WithOptional(e => e.podologo)
                .HasForeignKey(e => e.id_podologo);
        }
    }
}
