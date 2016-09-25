using System.Linq;
using System.Windows;
using Credential;
using BooksUI.ViewModels;
using System.Windows.Controls;

namespace BooksUI.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        LoginViewModel regionManager;
        public LoginView(LoginViewModel regionManager)
        {

            this.regionManager = regionManager;
            Loaded += (s, e) =>
            {
                DataContext = regionManager;
            };
          
            InitializeComponent();

        }

        private void loginSubmit_Click(object sender, RoutedEventArgs e)
        {
            regionManager.Authenticate();
             Close();
        }
    }
}
