using Credential;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace BooksUI.ViewModels
{
   public class LoginViewModel
    {
       
        public string userNameText { get; set; }

        public string userPassword { get; set; }

        Binding binding = new Binding();

        public LoginViewModel()
        {

        }

        public void Authenticate()
        {
            using (UserDbContext db = new UserDbContext())
            {
                var result = from b in db.users
                             where b.UserName == userNameText & b.Password == userPassword
                             select b;
                foreach (User u in result)
                {                   
                    singleton.Current.username = u.UserName;
                    singleton.Current.loginOk = true;
                }
                db.SaveChanges();

                MessageBox.Show(result.Count().ToString());
            }

        }
    }
}
