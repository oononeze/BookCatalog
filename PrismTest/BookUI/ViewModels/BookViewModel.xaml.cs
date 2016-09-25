using BookEntities;
using BookHandlersLibrary;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace BookUI.ViewModels
{
    /// <summary>
    /// Interaction logic for BookViewModel.xaml
    /// </summary>
    public partial class BookViewModel : UserControl
    {
       
        public BookViewModel()
        {

        }

        public static ObservableCollection<BookCategory> categories { get; set; }
                       = new ObservableCollection<BookCategory>();

        public static Books bookselected { get; set; }



    }
}
