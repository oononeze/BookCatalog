using System.ComponentModel;
using System.Data.Entity;

namespace Credential
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
       //u = ononeze p = cyril
    }
}
