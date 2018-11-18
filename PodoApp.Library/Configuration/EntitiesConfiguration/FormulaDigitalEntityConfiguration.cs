using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.EntitiesConfiguration
{
    public class FormulaDigitalEntityConfiguration : EntityTypeConfiguration<FormulaDigital>
    {
        public FormulaDigitalEntityConfiguration()
        {
            this.HasMany(e => e.decubitoSupinoExploracionMorfologica)
                .WithOptional(e => e.formulaDigital)
                .HasForeignKey(e => e.id_formula_digital);
        }
    }
}
