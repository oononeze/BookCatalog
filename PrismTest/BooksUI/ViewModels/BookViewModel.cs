
using System.Collections.ObjectModel;
using BookEntities;
using System.Linq;

namespace BooksUI.ViewModels
{
   public class BookViewModel
    {
        public static ObservableCollection<Category> bookCategories { get; set; }

        public BookViewModel()
        {
            bookCategories = new ObservableCollection<Category>();

            using (CategoryDbContext db = new CategoryDbContext())
            {
                var result = from b in db.categories
                             select b;

                foreach (Category category in db.categories)
                {
                    bookCategories.Add(category);
                }
            }

        }

        public static Books bookselected { get; set; }
    }
}
