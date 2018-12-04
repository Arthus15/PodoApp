using PodoApp.Library.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PodoApp.Library.Configuration.Entities
{
    public class DecubitoSupinoPosicionAnguloAntepieEntityConfiguration : EntityTypeConfiguration<DecubitoSupinoPosicionAnguloAntepie>
    {
        public DecubitoSupinoPosicionAnguloAntepieEntityConfiguration()
        {
            this.HasMany(e => e.decubitoSupinoExploracionArticular)
                .WithOptional(e => e.decubitoSupinoPosicionAnguloAntepie)
                .HasForeignKey(e => e.id_posicion_angulo_antepie);
        }
    }
}
