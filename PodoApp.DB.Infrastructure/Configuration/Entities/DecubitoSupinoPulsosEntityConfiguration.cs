using PodoApp.DB.Infrastructure.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class DecubitoSupinoPulsosEntityConfiguration : EntityTypeConfiguration<DecubitoSupinoPulsos>
    {
        public DecubitoSupinoPulsosEntityConfiguration()
        {
            this.HasMany(e => e.estudioOrtopodologico)
                .WithOptional(e => e.decubitoSupinoPulsos)
                .HasForeignKey(e => e.id_pulsos);
        }
    }
}
