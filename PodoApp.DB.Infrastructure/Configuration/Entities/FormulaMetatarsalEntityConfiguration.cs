using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
   public class FormulaMetatarsalEntityConfiguration : EntityTypeConfiguration<FormulaMetatarsal>
    {
        public FormulaMetatarsalEntityConfiguration()
        {
            this.HasMany(e => e.decubitoSupinoExploracionMorfologica)
                .WithOptional(e => e.formulaMetatarsal)
                .HasForeignKey(e => e.id_formula_metatarsal);
        }
    }
}
