using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookEntities;
 

namespace BookInterfaces
{
    public interface IBookCategoryHandlers
    {
        void createCategory(string name);
        void DeleteBookFromCategory(Books book);
        void addBookToCategory(Books book, string category);

    }
}
