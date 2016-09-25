using BookEntities;
using BookUI.ViewModels;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;


namespace BookUI.Views
{
    /// <summary>
    /// Interaction logic for BookView.xaml
    /// </summary>
    public partial class BookView : UserControl
    {

       

        public BookView(BookViewModel regionManager)
        {
         
            InitializeComponent();

            Loaded += (s, e) =>
            {
                DataContext = regionManager;             
            };
        }

        private void TreeView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            foreach(BookCategory category in BookViewModel.categories)
            {
                var bookName = (Books)treeView.SelectedItem;
                var result = from b in category.Books
                             where b.Name == bookName.Name
                             select b;

                foreach(Books book in result)
                {
                    BookDetailsViewModel.books = book.Name;
                }
               
            }
        }

     
    }
}
