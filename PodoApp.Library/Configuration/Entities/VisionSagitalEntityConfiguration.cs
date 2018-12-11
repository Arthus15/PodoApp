﻿using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.Entities
{
    public class VisionSagitalEntityConfiguration : EntityTypeConfiguration<VisionSagital>
    {
        public VisionSagitalEntityConfiguration()
        {
            this.HasMany(e => e.estudioOrtopodologico)
                .WithOptional(e => e.visionSagital)
                .HasForeignKey(e => e.id_adv_sagital);
        }
    }
}