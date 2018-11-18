﻿using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.EntitiesConfiguration
{
   public class DecubitoSupinoExploracionMuscularEntityConfiguration : EntityTypeConfiguration<DecubitoSupinoExploracionMuscular>
    {
        public DecubitoSupinoExploracionMuscularEntityConfiguration()
        {
            this.HasMany(e => e.estudioOrtopodologico)
                .WithOptional(e => e.decubitoSupinoExploracionMuscular)
                .HasForeignKey(e => new { e.id_dse_muscular_izdo, e.id_dse_muscular_dcho });
        }
    }
}
