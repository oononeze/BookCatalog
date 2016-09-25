using BookEntities;
using System.ComponentModel;
using System.Windows.Controls;

namespace BookUI.ViewModels
{
    /// <summary>
    /// Interaction logic for BookDetailsViewModel.xaml
    /// </summary>
    public partial class BookDetailsViewModel : UserControl
    {

        public static string books
        {
            get; set;
        }

        public  string BookName
        {
            get
            {
                return books;
            }

            set
            {
                if (value != books)
                {
                    value = books;
                    NotifyPropertyChanged("BookName");

                }

            }
        }

        public static Books bn { get; set; }


        BookCategory bc = new BookCategory("Fiction");
        private static Books book;
        public  Books Book
        {
            get
            {
                return book;
            }

            set
            {
                if (book != BookViewModel.bookselected)
                {
                    book = BookViewModel.bookselected;
                    NotifyPropertyChanged("Book");
                  
                }

            }
        }

        public BookDetailsViewModel()
        {
            InitializeComponent();
            Book = new Books(bc) { Name = "balls", Author = "rubbish", Publisher = "More Balls" };
            bn = new Books();
            bn.Name = "Balls";
           
           
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
