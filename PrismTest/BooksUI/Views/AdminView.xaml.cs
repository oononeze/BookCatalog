using BookEntities;
using BooksUI.ViewModels;
using Credential;
using System;
using System.Windows;
using System.Windows.Controls;

namespace BooksUI.Views
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : UserControl
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginViewModel regionManager = new LoginViewModel();
            
             Window loginControl = new LoginView(regionManager);
            
             loginControl.ShowDialog();

            if (singleton.Current.loginOk)
            {
                userText.Inlines.Add("Welcome: " + singleton.Current.username);
                AddBookButton.Visibility = Visibility.Visible;
                DeleteBookButton.Visibility = Visibility.Visible;
                AddCategoryButton.Visibility = Visibility.Visible;
            }



        }

        private void AddCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            Window addCategory = new CrudViews.AddCategoryView();
            addCategory.ShowDialog();
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            Window addbook = new CrudViews.AddBookView();
            addbook.ShowDialog();
        }
    }
}
