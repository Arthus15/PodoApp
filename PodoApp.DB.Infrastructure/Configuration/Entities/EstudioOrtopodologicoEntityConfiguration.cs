using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class EstudioOrtopodologicoEntityConfiguration : EntityTypeConfiguration<EstudioOrtopodologico>
    {
        public EstudioOrtopodologicoEntityConfiguration()
        {
            this.HasMany(e => e.primeraVisita)
                .WithOptional(e => e.estudioOrtopodologico)
                .HasForeignKey(e => e.id_estudio_ortopodologico);
        }
    }
}
