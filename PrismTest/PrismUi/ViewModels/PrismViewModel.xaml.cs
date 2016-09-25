
using BookEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrismUi.ViewModels
{
    /// <summary>
    /// Interaction logic for PrismViewModel.xaml
    /// </summary>
    public partial class PrismViewModel : UserControl
    {
        public PrismViewModel(BookHandlers bookHandler)
        {
            categoryHanler = bookHandler;
        }

        public IEnumerable<BookCategory> categories
        {
            get
            {
                return categoryHanler.ListCategories;
            }
        }
        BookHandlers categoryHanler;
    }
}
