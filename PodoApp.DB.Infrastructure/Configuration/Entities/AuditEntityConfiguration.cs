using PodoApp.DB.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Entities
{
    public class AuditEntityConfiguration : EntityTypeConfiguration<Audit>
    {
        public AuditEntityConfiguration()
        {
            this.ToTable("Audit");
            HasKey(p => p.Id);
        }
    }
}
