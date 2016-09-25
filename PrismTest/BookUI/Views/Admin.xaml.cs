using Credentials;
using System.Windows;
using System.Windows.Controls;
using BookHandlersLibrary;
using System.Linq;
using BookEntities;
using System;

namespace BookUI.Views
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : UserControl
    {
        public  Admin()
        {
            InitializeComponent();

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
                    
            Window loginControl = new LoginView();
            loginControl.ShowDialog();

            if (singleton.Current.loginOk)
            {
                userText.Inlines.Add("Welcome " + singleton.Current.username);
                AddBookButton.Visibility = Visibility.Visible;
                DeleteBookButton.Visibility = Visibility.Visible;
                AddCategoryButton.Visibility = Visibility.Visible;
            }



        }

        private void AddCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            Window addCategory = new CrudViews.AddCategory();
            addCategory.ShowDialog();

            try
            {
                ViewModels.BookViewModel.categories.Add(new BookCategory(singleton.Current.categoryAddName));
                MessageBox.Show("Category added successfully");
               
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            Window addbook = new CrudViews.AddBookView();
            addbook.ShowDialog();
        }
    }
}
