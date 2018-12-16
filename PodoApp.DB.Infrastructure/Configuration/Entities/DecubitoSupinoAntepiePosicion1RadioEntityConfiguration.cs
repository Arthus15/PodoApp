using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class DecubitoSupinoAntepiePosicion1RadioEntityConfiguration : EntityTypeConfiguration<DecubitoSupinoAntepiePosicion1Radio>
    {
        public DecubitoSupinoAntepiePosicion1RadioEntityConfiguration()
        {
            this.HasMany(e => e.decubitoSupinoExploracionArticular)
                .WithOptional(e => e.decubitoSupinoAntepiePosicion1Radio)
                .HasForeignKey(e => e.id_posicion_1_radio);
        }
    }
}
