using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.Entities
{
    public class AntecedentesPatologicosEntityConfiguration : EntityTypeConfiguration<AntecedentesPatologicos>
    {
        public AntecedentesPatologicosEntityConfiguration()
        {
            this.HasMany(e => e.historialClinico)
                .WithOptional(e => e.antecedentesPatologicos)
                .HasForeignKey(e => e.id_ant_patologicos);
        }
    }
}
