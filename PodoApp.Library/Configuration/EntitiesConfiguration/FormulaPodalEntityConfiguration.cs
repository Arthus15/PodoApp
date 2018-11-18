using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.EntitiesConfiguration
{
    public class FormulaPodalEntityConfiguration : EntityTypeConfiguration<FormulaPodal>
    {
        public FormulaPodalEntityConfiguration()
        {
            this.HasMany(e => e.decubitoSupinoExploracionMorfologica)
                .WithOptional(e => e.formulaPodal)
                .HasForeignKey(e => e.id_formula_podal);
        }
    }
}
