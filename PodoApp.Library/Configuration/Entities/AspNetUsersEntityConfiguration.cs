using PodoApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Library.Configuration.Entities
{
   public class AspNetUsersEntityConfiguration : EntityTypeConfiguration<AspNetUsers>
    {
        public AspNetUsersEntityConfiguration()
        {
            this.HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);
        }
    }
}
