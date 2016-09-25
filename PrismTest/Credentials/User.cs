using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Credentials
{
    public class User
    {
        public int ID { get; set; }

        [DisplayName("User-Name")]
        public string UserName { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }
    }

    public class UserDbContext : DbContext
    {
       public DbSet<User> users { get; set; }
    }
}
