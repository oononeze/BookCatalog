using System.Windows;

namespace BookUI.CrudViews
{
    /// <summary>
    /// Interaction logic for AddCategory.xaml
    /// </summary>
    public partial class AddCategory : Window
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void addCategory_Click(object sender, RoutedEventArgs e)
        {
            singleton.Current.categoryAddName = categoryName.Text;
            Close();
        }
    }
}
