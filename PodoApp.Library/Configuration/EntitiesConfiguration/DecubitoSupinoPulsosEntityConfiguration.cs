﻿using PodoApp.Library.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PodoApp.Library.Configuration.EntitiesConfiguration
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
