using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class PrimeraVisitaEntityConfiguration : EntityTypeConfiguration<PrimeraVisita>
    {
        public PrimeraVisitaEntityConfiguration()
        {
            this.HasMany(e => e.diagnostico)
                .WithOptional(e => e.primeraVisita)
                .HasForeignKey(e => e.id_primera_visita);

            this.HasMany(e => e.pruebasComplementarias)
                .WithOptional(e => e.primeraVisita)
                .HasForeignKey(e => e.id_primera_visita);
        }
    }
}
