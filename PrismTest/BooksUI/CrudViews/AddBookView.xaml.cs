using BookEntities;
using System;
using System.Linq;
using System.Windows;

namespace BooksUI.CrudViews
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
            Books book = new Books();
            book.Name = BookNameTextbox.Text;
            book.Author = AuthorTextBox.Text;
            book.Publisher = PublishersTextbox.Text;
            book.Description = DescriptionTextbox.Text;

            using (CategoryDbContext categorydb = new CategoryDbContext())
            {
                var result = categorydb.categories.Where(b => b.Name == CategoryTextbox.Text);

                foreach(Category category in result)
                {
                    category.books.Add(book);
                }
            }

            using (BooksDbContext db = new BooksDbContext())
            {
                db.Books.Add(book);
            }
                Close();
        }
    }
}
