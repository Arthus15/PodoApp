using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Configuration.Owin
{
   public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("Data Source=LAPTOP-FUFCKL29;Initial Catalog=podologia;Integrated Security=True", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            var p = new ApplicationDbContext();
            return p;
        }
    }
}
