using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class CalzadoHabitualEntityConfiguration : EntityTypeConfiguration<CalzadoHabitual>
    {
        public CalzadoHabitualEntityConfiguration()
        {
            this.HasMany(e => e.primeraVisita)
                .WithOptional(e => e.calzadoHabitual)
                .HasForeignKey(e => e.id_calzado_habitual);
        }
    }
}
