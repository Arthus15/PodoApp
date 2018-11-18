﻿using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.EntitiesConfiguration
{
    public class TratamientoEntityConfiguration : EntityTypeConfiguration<Tratamiento>
    {
        public TratamientoEntityConfiguration()
        {
            this.HasMany(e => e.diagnostico)
                .WithOptional(e => e.tratamiento)
                .HasForeignKey(e => e.id_tratamiento);

            this.HasMany(e => e.materialSoportePlantar)
                .WithOptional(e => e.tratamiento)
                .HasForeignKey(e => e.id_tratamiento);
        }
    }
}
