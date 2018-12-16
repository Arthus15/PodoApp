using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class PacienteEntityConfiguration : EntityTypeConfiguration<Paciente>
    {
        public PacienteEntityConfiguration()
        {
            this.HasMany(e => e.consulta)
                .WithOptional(e => e.paciente)
                .HasForeignKey(e => e.id_paciente);

            this.HasMany(e => e.primeraVisita)
                .WithOptional(e => e.paciente)
                .HasForeignKey(e => e.id_paciente);
        }
    }
}
