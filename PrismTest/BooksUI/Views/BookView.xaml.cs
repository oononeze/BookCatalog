using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookEntities;
using BooksUI.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace BooksUI.Views
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

    }
}
