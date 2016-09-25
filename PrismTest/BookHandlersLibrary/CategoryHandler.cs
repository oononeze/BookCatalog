using BookEntities;
using BookInterfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookHandlersLibrary
{
    public class CategoryHandler: IBookCategoryHandlers
    {
      
        public void createCategory(string Name)
        {

            using (BookCategoriesDbContext db = new BookCategoriesDbContext())
            {
                db.categories.Add(new BookCategory() { ID = 1, Name = Name });
                db.SaveChanges();
                MessageBox.Show("Category added successfully total category count is: "
                    + db.categories.Count().ToString());
            }

        }

        public void addBookToCategory(Books book, string category)
        {
            //if (book.bookCategory.Books.Contains(book))
            //{
            //    book.bookCategory.Books.Remove(book);
            //}

            //var result = from x in bookCategoryList
            //             where category == x.Name
            //             select x;

            //BookCategory cat = result as BookCategory;
            //cat.Books.Add(book);


        }

        public void DeleteBookFromCategory(Books book)
        {
           //  book.bookCategory.Books.Remove(book);
        }

    }
}
