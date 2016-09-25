using BookEntities;
using System;
using System.Windows;

namespace BookUI.CrudViews
{
    /// <summary>
    /// Interaction logic for AddBookView.xaml
    /// </summary>
    public partial class AddBookView : Window
    {
        public AddBookView()
        {
            InitializeComponent();
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BookHandlers bh = new BookHandlers();

                foreach (BookCategory category in ViewModels.BookViewModel.categories)
                {
                    if (category.Name == "Sci-Fi")
                    {
                        category.Books.Add(bh.CreateBook("Sci-Fi", BookNameTextbox.Text, AuthorTextBox.Text, PublishersTextbox.Text));
                    }
                }

                MessageBox.Show("Book added successfully");
            }

           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
            Close();

        }
    }
}
