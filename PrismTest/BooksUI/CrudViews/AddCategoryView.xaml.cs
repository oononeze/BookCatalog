using System.Windows;
using BookHandlersLibrary;
using BookEntities;
using System.Linq;

namespace BooksUI.CrudViews
{
    /// <summary>
    /// Interaction logic for AddCategoryView.xaml
    /// </summary>
    public partial class AddCategoryView : Window
    {
        CategoryHandler categoryHandler = new CategoryHandler();

        public AddCategoryView()
        {
            InitializeComponent();
        }

        private void addCategory_Click(object sender, RoutedEventArgs e)
        {
            categoryHandler.createCategory(categoryName.Text);
              Close();
        }
    }
}
