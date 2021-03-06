﻿using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class PersonaEntityConfiguration : EntityTypeConfiguration<Persona>
    {
        public PersonaEntityConfiguration()
        {
            this.HasMany(e => e.paciente)
                .WithOptional(e => e.persona)
                .HasForeignKey(e => e.id_persona);

            this.HasMany(e => e.podologo)
                .WithOptional(e => e.persona)
                .HasForeignKey(e => e.id_persona)
                .WillCascadeOnDelete();
        }
    }
}
