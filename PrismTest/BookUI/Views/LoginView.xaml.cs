using System.Linq;
using System.Windows;
using Credentials;

namespace BookUI.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();            
        }

        private void loginSubmit_Click(object sender, RoutedEventArgs e)
        {
           
            using (UserDbContext db = new UserDbContext())
            {
                var result = from b in db.users
                             where b.UserName == userName.Text & b.Password == password.Password                            
                             select b;
                foreach(User u in result)
                {
                    singleton.Current.username = u.UserName;
                    singleton.Current.loginOk = true;
                }

               Close();
            

            }
        }
    }
}
